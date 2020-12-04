using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models
{
    public class InnerTop
    {
        public string OwnerName { get; set; }
        public string OwnerDescription { get; set; }
        public string OwnerDescription2 { get; set; }

        public InnerTop(string ownerName, string ownerDescription, string ownerDescription2)
        {
            OwnerName = ownerName;
            OwnerDescription = ownerDescription;
            OwnerDescription2 = ownerDescription2;
        }
    }

    public class Service
    {
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }

    public class PriceTable
    {
        public string PriceTableTitle { get; set; }
        public string Price { get; set; }
        public string PriceTableDescription { get; set; }
    }
    public class Ability
    {
        public string AbilityTitle { get; set; }
    }
    public class Customers
    {
        public string CustomersTitle { get; set; }
    }


}
