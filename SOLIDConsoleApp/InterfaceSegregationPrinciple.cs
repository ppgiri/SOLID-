using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
{
    interface ISmartPhone
    {
        void SmartCall();
        void FaceLock();
    }

    interface INewSmartPhone : ISmartPhone
    {
        void SecretPasCode();
    }
    public class NewPhoneGeneration : ISmartPhone
    {
        public void SmartCall()
        {
            Console.WriteLine("smartcall can be done here");
        }

        public void FaceLock()
        {
            Console.WriteLine("face lock for security");

        }
    }
}
   