using System;
using System.Collections.Generic;
namespace AggergateAndIterator
{
    public class Customer
    {
        public Customer()
        {
            _addresses = new List<Address>();
        }
        private List<Address> _addresses { get; set; }
        //aggergate through root
        public IEnumerable<Address> GetAddresses()
        {
            return _addresses;
        }

        public void Add(Address add)
        {

            foreach (var address in _addresses)
            {
                if (add.Type == address.Type)
                {
                    throw new Exception("Not allowed");
                }
            }
            _addresses.Add(add);
        }

    }
}
