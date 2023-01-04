using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst15PostalBag
{
    internal class Letter
    {
        protected bool _registered;
        public Letter(string recipient, string sender, bool registered = false)
        {
            Recipient = recipient;
            Sender = sender;
            Registered = registered;
            //Price = Registered ? 20 : 10;
        }

        public string Recipient { get; set; }
        public string Sender { get; set; }
        public float Price { get { return _registered ? 20 : 10; } }
        public bool Registered 
        {
            get { return _registered; }
            set { 
                _registered = value;
                //Price = _registered ? 20 : 10;
            }
        }
        // public float Price { get; set; }
    }
}
