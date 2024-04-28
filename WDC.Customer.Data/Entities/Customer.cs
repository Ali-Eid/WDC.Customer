using System;
namespace WDC.Customers.Data.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

    }
}

