using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
{
    //Single Responsibility Principle (every class with one responsibility)
    class Phone
    {
        public void Call(int number)
        {
            Console.WriteLine("Call to the number" + number.ToString());
        }
        
    }

    class MobilePhone
    {

        public void Message()
        {
            Console.WriteLine("Message is to be sent ");
        }
    }
}
