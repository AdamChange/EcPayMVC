namespace EcPayMVC.Controllers
{
    public class EcPayController : Controller
    {
        private readonly string _ecPayUrl;
        private readonly IBOVMService _bovmService;
        private readonly IEcPayService _ecPayService;
        private readonly ITakeoutEcPayService _takeoutEcpay;
        private readonly IOrderdetailsViewModelService _orderdetailsViewModelService;

        public EcPayController(ITakeoutEcPayService ecpayservice, IConfiguration configuration, IEcPayService ecPayService, ITakeoutEcPayService takeoutEcpay, IBOVMService bovmService, IOrderdetailsViewModelService orderdetailsViewModelService)
        {
            _ecPayUrl = configuration.GetSection("EcPaySettings:ApiUrl").Value;
            _takeoutEcpay = takeoutEcpay;
            _ecPayService = ecPayService;
            _bovmService = bovmService;
            _orderdetailsViewModelService = orderdetailsViewModelService;
        }
        
        [HttpPost]
        public IActionResult ReturnUrl(IFormCollection input)
        {
            //根據綠界回傳Form形式資料，轉化成Dictionary
            var requestData = input.Where(x => x.Key != "CheckMacValue").ToDictionary(x => x.Key, x => x.Value.ToString());
            //加密成CheckMacValue
            var checkValue = _ecPayService.BuildCheckMacValue(requestData);
            //比對綠界的回傳的CheckMacValue
            var isValid = checkValue == input["CheckMacValue"];
            if (!isValid)
            {
                return BadRequest();
            }
            var CheckMacValueStr = input["MerchantTradeNo"].ToString();
            BookingOrder order = _bovmService.GetOrderByTradeNo(CheckMacValueStr);
            if (order!=null)
            {
                _bovmService.UpdateStatus(order.BookingOrderId, 2);//輸入BookingId,修改狀態值為2
                _bovmService.SendBookingOrederEmailAsync(order.BookingOrderId, true);//寄信
            }
            return Ok("1|OK");
        }
    }
}
