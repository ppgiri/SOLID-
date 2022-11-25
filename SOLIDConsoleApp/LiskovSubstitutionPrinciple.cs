using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
{
    public abstract class MobileCell
    {
        public abstract void SendEmail();
        public abstract void SendVideo();
        
    }

    public class IPhone : MobileCell
    {
        public override void SendEmail()
        {
            Console.WriteLine("send the email to me");
        }

        public override void SendVideo()
        {
            Console.WriteLine("Video call me on whatsapp");
        }

    }

    public class AndroidPhone : MobileCell
    {
        public override void SendEmail()
        {
            Console.WriteLine("sending the email to different people");
        }

        public override void SendVideo()
        {
            Console.WriteLine("Video can be send for whatsapp");
        }

    }


}
