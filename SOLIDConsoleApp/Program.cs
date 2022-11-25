using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Call(87654);
            MobilePhone mobilephone = new MobilePhone();
            mobilephone.Message();
            Mobile mobile = new Mobile();
            mobile.CallNormal();
            AndroidMobile androidmobile = new AndroidMobile();
            androidmobile.NewGenerationCall();
            IPhone iPhone = new IPhone();
            iPhone.SendEmail();
            iPhone.SendVideo();
            NewPhoneGeneration newphonegeneration = new NewPhoneGeneration();
            newphonegeneration.SmartCall();
            newphonegeneration.FaceLock();
            UpdatedPhone updatedphone = new UpdatedPhone();
            updatedphone.SecretPasCode();
            Console.ReadLine();
            Payments payments = new Payments();
            payments.MakePayment(UpiPayment);
            Console.ReadLine();
        }
    }
}
