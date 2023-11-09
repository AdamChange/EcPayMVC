using EcPayMVC.ViewModels.EcPay;
using System.Web;
using EcPayMVC.Helpers.EcPay;

namespace EcPayMVC.Services.EcPay
{
    public class EcPayService : IEcPayService
    {
        private readonly IRepository<Restaurant> _restRepo;
        private readonly IRepository<BookingOrder> _bookingOredrRepo;
        private readonly string _MerchantID;
        private readonly string _HashKey;
        private readonly string _HashIV;

        public EcPayService(IConfiguration configuration, IRepository<Restaurant> restRepo, IRepository<BookingOrder> bookingOredrRepo)
        {
            _MerchantID = configuration.GetSection("EcPaySettings:MerchantID").Value;
            _HashKey = configuration.GetSection("EcPaySettings:HashKey").Value;
            _HashIV = configuration.GetSection("EcPaySettings:HashIV").Value;
            _restRepo = restRepo;
            _bookingOredrRepo = bookingOredrRepo;
        }
        //一般信用卡測試卡號 : 4311-9522-2222-2222 安全碼 : 222
        public async Task<EcPayCreateOrderViewModel> CreateBookingOrderEcPay(BookingOrder order)
        {
            
            Restaurant rest = await _restRepo.FirstOrDefaultAsync(x => x.RestaurantId == order.RestaurantId);
            var result = new EcPayCreateOrderViewModel()
            {
                MerchantID = _MerchantID,//商店ID
                MerchantTradeNo = $"T{DateTime.Now.Ticks}",//訂單編號
                MerchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),//交易日期
                PaymentType = "aio",//固定
                TotalAmount = (int)(order.Seat*rest.DepositPrice),//價錢
                TradeDesc = $"{rest.RestaurantName}訂位",//交易標題
                ItemName = $"{order.Seat}人_{order.DiningDatetime.ToString("MM/dd HH:mm")},一人{rest.DepositPrice}元",//交易內容
                ReturnURL = "https://openablefront.azurewebsites.net/EcPay/ReturnUrl",//回傳主機之URL
                //ReturnURL = "https://4aa4-1-164-248-114.ngrok-free.app/ecpay/returnurl",//ngork測試用
                //ReturnURL = "https://localhost:7114/EcPay/ReturnUrl",//localhost測試用
                ChoosePayment = "ALL",//付款方式
                EncryptType = 1,//加密類型，固定填1
                ClientBackURL = $"https://openablefront.azurewebsites.net/Order/{order.BookingOrderId}"//結束按鈕返回URL
                //ClientBackURL = $"https://67cb-1-164-231-28.ngrok-free.app/Order/{order.BookingOrderId}"//ngork測試用
                //ClientBackURL = $"https://localhost:7114/Order/{order.BookingOrderId}"//localhost測試用
            };
            var myData = new Dictionary<string, string>()
            {
                {"MerchantID",result.MerchantID },
                {"MerchantTradeNo",result.MerchantTradeNo },
                {"MerchantTradeDate",result.MerchantTradeDate },
                {"PaymentType",result.PaymentType },
                {"TotalAmount",result.TotalAmount.ToString() },
                {"TradeDesc",result.TradeDesc },
                {"ItemName",result.ItemName },
                {"ReturnURL",result.ReturnURL },
                {"ChoosePayment",result.ChoosePayment },
                {"EncryptType",result.EncryptType.ToString() },
                {"ClientBackURL",result.ClientBackURL },
            };
            result.CheckMacValue = BuildCheckMacValue(myData, _HashKey, _HashIV);
            order.EcPayCheckValue=result.MerchantTradeNo;
            await _bookingOredrRepo.UpdateAsync(order);
            return result;
        }
        public EcPayCreateOrderViewModel CreatePaymentOrder(decimal orderAmount)
        {
            var result = new EcPayCreateOrderViewModel()
            {
                MerchantID = _MerchantID,//商店ID
                MerchantTradeNo = $"T{DateTime.Now.Ticks}",//訂單編號 
                MerchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),//交易日期
                PaymentType = "aio",//固定
                TotalAmount = (int)orderAmount,//價錢
                TradeDesc = "測試交易",//交易標題
                ItemName = $"測試-{orderAmount}",//交易內容
                ReturnURL = "https://openablefront.azurewebsites.net/OrderPay/ReturnUrl",//回傳主機之URL
                ChoosePayment = "ALL",//付款方式
                EncryptType = 1,//加密類型，固定填1
                ClientBackURL = "https://openablefront.azurewebsites.net/"//結束按鈕返回URL,返回首頁
            };
            var myData = new Dictionary<string, string>()
            {
                {"MerchantID",result.MerchantID },
                {"MerchantTradeNo",result.MerchantTradeNo },
                {"MerchantTradeDate",result.MerchantTradeDate },
                {"PaymentType",result.PaymentType },
                {"TotalAmount",result.TotalAmount.ToString() },
                {"TradeDesc",result.TradeDesc },
                {"ItemName",result.ItemName },
                {"ReturnURL",result.ReturnURL },
                {"ChoosePayment",result.ChoosePayment },
                {"EncryptType",result.EncryptType.ToString() },
                {"ClientBackURL",result.ClientBackURL },
            };
            result.CheckMacValue = BuildCheckMacValue(myData, _HashKey, _HashIV);
            return result;
        }
        private string BuildCheckMacValue(Dictionary<string, string> myData, string hashKey, string hashIv)
        {

            var str = string.Join("&", myData.OrderBy(x => x.Key).Select(x => $"{x.Key}={x.Value}"));//(1) 將傳遞參數依照第一個英文字母，由A到Z的順序來排序(遇到第一個英名字母相同時，以第二個英名字母來比較，以此類推)，並且以&方式將所有參數串連。
            var para = $"HashKey={hashKey}&{str}&HashIV={hashIv}";//(2) 參數最前面加上HashKey、最後面加上HashIV
            var encodeStr = HttpUtility.UrlEncode(para).ToLower();//(3) 將整串字串進行URL encode//(4) 轉為小寫
            var encryptStr = encodeStr.GetSHA256();//(5) 以SHA256加密方式來產生雜凑值
            var chenkMacValue = encryptStr.ToUpper();//(6) 再轉大寫產生CheckMacValue
            return chenkMacValue;
        }
        public string BuildCheckMacValue(Dictionary<string, string> myData)
        {
            string hashKey = _HashKey;
            string hashIv = _HashIV;
            var str = string.Join("&", myData.OrderBy(x => x.Key).Select(x => $"{x.Key}={x.Value}"));//(1) 將傳遞參數依照第一個英文字母，由A到Z的順序來排序(遇到第一個英名字母相同時，以第二個英名字母來比較，以此類推)，並且以&方式將所有參數串連。
            var para = $"HashKey={hashKey}&{str}&HashIV={hashIv}";//(2) 參數最前面加上HashKey、最後面加上HashIV
            var encodeStr = HttpUtility.UrlEncode(para).ToLower();//(3) 將整串字串進行URL encode//(4) 轉為小寫
            var encryptStr = encodeStr.GetSHA256();//(5) 以SHA256加密方式來產生雜凑值
            var chenkMacValue = encryptStr.ToUpper();//(6) 再轉大寫產生CheckMacValue
            return chenkMacValue;
        }
    }
}
