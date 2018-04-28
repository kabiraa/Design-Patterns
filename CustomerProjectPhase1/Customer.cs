using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase
    {
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate() { }
    }

    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (Name.Length == 0)
            {
                throw new Exception("Name is mandatory.");
            }
            if (Phonenumber.Length == 0)
            {
                throw new Exception("Phonenumber is mandatory.");
            }
            if (BillAmount == 0)
            {
                throw new Exception("BillAmount is mandatory.");
            }
            if (BillDate <= DateTime.MinValue)
            {
                throw new Exception("Bill Date is mandatory.");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required.");
            }
        }
    }

    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (Name.Length == 0)
            {
                throw new Exception("Name is mandatory.");
            }
            if (Phonenumber.Length == 0)
            {
                throw new Exception("Phonenumber is mandatory.");
            }
        }
    }
    
}
