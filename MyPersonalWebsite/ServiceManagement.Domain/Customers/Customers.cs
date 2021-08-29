using _0_Framework.Domain;

namespace ServiceManagement.Domain.Customers
{
    public class Customers : EntityBase
    {
        public string CustomerName { get; private set; }
        public string CustomerLogo { get; private set; }
        public string LogoAlt { get; private set; }
        public string LogoTitle { get; private set; }


        public Customers(string customerName, string customerLogo, string logoAlt, string logoTitle)
        {
            CustomerName = customerName;
            CustomerLogo = customerLogo;
            LogoAlt = logoAlt;
            LogoTitle = logoTitle;
        }

        public void Edit(string customerName, string customerLogo, string logoAlt, string logoTitle)
        {
            CustomerName = customerName;
            LogoAlt = logoAlt;
            LogoTitle = logoTitle;

            if (!string.IsNullOrWhiteSpace(customerLogo))
            {
                CustomerLogo = customerLogo;
            }
        }
    }
}
