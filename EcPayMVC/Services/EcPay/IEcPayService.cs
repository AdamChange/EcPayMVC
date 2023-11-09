using EcPayMVC.Entities;
using EcPayMVC.ViewModels.EcPay;

namespace EcPayMVC.Services.EcPay
{
    public interface IEcPayService
    {
        Task<EcPayCreateOrderViewModel> CreateBookingOrderEcPay(BookingOrder order);
        EcPayCreateOrderViewModel CreatePaymentOrder(decimal orderAmount);
        string BuildCheckMacValue(Dictionary<string, string> myData);
    }
}