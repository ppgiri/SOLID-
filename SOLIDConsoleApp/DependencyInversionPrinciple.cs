using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
{

    public class MobilePayments
{
    private PaymentType paymentType;

    public MobilePayments( CardPayment card)
    {
        PaymentType = card();
    }
    public MobilePayments(UpiPayment upi)
    {
        paymentType = upi();
    }
    public MobilePayments (PaypalPayment paypal)
    {
        paymentType = paypal();
    }

    public string MakePayment()
    {
        paymentType.Pay();
    }
}

}
