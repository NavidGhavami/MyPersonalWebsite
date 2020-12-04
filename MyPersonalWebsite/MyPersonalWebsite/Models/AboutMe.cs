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
        public long ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }

        public Service(string serviceTitle, string serviceDescription, long serviceId)
        {
            ServiceID = serviceId;
            ServiceTitle = serviceTitle;
            ServiceDescription = serviceDescription;
            
        }
    }

    public class PriceTable
    {
        public long PriceID { get; set; }
        public string PriceTableTitle { get; set; }
        public string Price { get; set; }
        public string PriceTableDescription { get; set; }

        public PriceTable(string priceTableTitle, string price, string priceTableDescription, long priceId)
        {
            PriceID = priceId;
            PriceTableTitle = priceTableTitle;
            Price = price;
            PriceTableDescription = priceTableDescription;
        }
    }
    public class Ability
    {

        public long AbilityID { get; set; }
        public string AbilityTitle { get; set; }

        public Ability(long abilityId, string abilityTitle)
        {
            AbilityID = abilityId;
            AbilityTitle = abilityTitle;
        }
    }
    public class Client
    {
        public long ClientID { get; set; }
        public string ClientTitle { get; set; }
        public string ClientLogo { get; set; }

        public Client(long clientId, string clientTitle,string clientLogo)
        {
            ClientID = clientId;
            ClientTitle = clientTitle;
            ClientLogo = clientLogo;
        }
    }


}
