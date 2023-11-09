using System.ComponentModel.DataAnnotations;

namespace EcPayMVC.ViewModels.EcPay
{
    public class EcPayCreateOrderViewModel
    {
        //特店編號 必填
        [StringLength(10)]
        public string MerchantID { get; set; }
        //特店訂單編號 必填，特店訂單編號均為唯一值，不可重複使用。英數字大小寫混合
        [StringLength(20)]
        public string MerchantTradeNo { get; set; }
        //特店交易時間 必填，格式為：yyyy/MM/dd HH:mm:ss
        [StringLength(20)]
        public string MerchantTradeDate { get; set; }
        //交易類型 必填，請固定填入 aio
        [StringLength(20)]
        public string PaymentType { get; set; }
        //交易金額 必填，請帶整數，不可有小數點。僅限新台幣
        public int TotalAmount { get; set; }
        //交易描述 必填，請勿帶入特殊字元。
        [StringLength(200)]
        public string TradeDesc { get; set; }
        //商品名稱 必填 如果商品名稱有多筆，需在金流選擇頁一行一行顯示商品名稱的話，商品名稱請以符號#分隔。詳細的使用注意事項請參考FAQ。
        [StringLength(400)]
        public string ItemName { get; set; }
        //付款完成通知回傳網址 必填，ReturnURL為付款結果通知回傳網址，為特店server或主機的URL，用來接收綠界後端回傳的付款結果通知。當消費者付款完成後，綠界會將付款結果參數以幕後回傳到該網址。詳細說明請參考付款結果通知
        //1.請勿設定與Client端接收付款結果網址OrderResultURL相同位置，避免程式判斷錯誤。
        //2.ReturnURL收到綠界後端回傳的付款結果通知後，請回應字串1|OK給綠界。
        //3.1|OK僅是廠商回應綠界是否收到通知，並不會改變付款狀態。
        //4.參數內容若有包含%26(&)及%3C(<) 這二個值時，請先進行urldecode() 避免呼叫API失敗。
        [StringLength(200)]
        public string ReturnURL { get; set; }
        //選擇預設付款方式 必填，Credit：信用卡及銀聯卡(需申請開通)
        [StringLength(20)]
        public string ChoosePayment {  get; set; }
        //檢查碼 必填，請參考檢查碼機制
        public string CheckMacValue { get; set; }
        //CheckMacValue加密類型 必填，請固定填入1，使用SHA256加密。
        public int EncryptType { get; set; }
        //Client端返回特店的按鈕連結，消費者點選此按鈕後，會將頁面導回到此設定的網址
        [StringLength(200)]
        public string ClientBackURL { get; set; }
    }
}
