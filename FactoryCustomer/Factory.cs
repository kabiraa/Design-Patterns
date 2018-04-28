using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiddleLayer;

namespace FactoryCustomer
{
    public static class Factory
    {
        static Dictionary<string, CustomerBase> customer;

        static Factory()
        {
            customer = new Dictionary<string, CustomerBase>();
            customer.Add("Customer", new Customer());
            customer.Add("Lead", new Lead());
        }

        public static CustomerBase CreateCustomer(string customerType)
        {
            return customer[customerType];
        }
    }
}
