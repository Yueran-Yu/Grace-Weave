using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone nok = new NokiaPhone();
            EricssonPhone ers = new EricssonPhone();
            var user = new PhoneUser(ers);
            user.UsePhone();
        }
    }

    class PhoneUser
    {
        private Iphone _phone;
        public PhoneUser(Iphone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();
        }
    }


    interface Iphone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }

    class NokiaPhone : Iphone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello this is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring...!");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : Iphone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello this is Tim!");
        }
        
        public void Receive()
        {
            Console.WriteLine("Ericsson message ring...!");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

}
