using System;
using System.Collections.Generic;

namespace DataBindingToCollectionsDemo.Data
{
    public class Customer
    {
        public Customer()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CustomerID { get; set; }
        public int Age { get; set; }
    }

    public class CustomerCollection : List<Customer>
    {
        public CustomerCollection()
        {
        }
    }
}
