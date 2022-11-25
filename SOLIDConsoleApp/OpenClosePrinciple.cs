using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDConsoleApp
    //open for extension but closed for modification (the core class should not be disturbed )
{
    //parent class which is not to be modified but can be extendede
    class Mobile   
    {
        public void CallNormal()
        {
            Console.WriteLine("Calling you Normal");
        }
        public void Messaging() 
        {
            Console.WriteLine(" SMS messaging is available");
        }
        
    }

    // child class which extends the parent class
    class AndroidMobile : Mobile
    {
        public void NewGenerationCall()
        {
            Console.WriteLine(" Whats app call using WIFI ");

        }
    }
}
