using _0_Framework.Domain;

namespace ServiceManagement.Domain.Services
{
    public class Services : EntityBase
    {
        public string ServiceName { get; private set; }
        public string ServiceLogo { get; private set; }
        public string ServiceDescription { get; private set; }


        public Services(string serviceName, string serviceLogo, string serviceDescription)
        {
            ServiceName = serviceName;
            ServiceLogo = serviceLogo;
            ServiceDescription = serviceDescription;
        }

        public void Edit(string serviceName, string serviceLogo, string serviceDescription)
        {
            ServiceName = serviceName;
            ServiceLogo = serviceLogo;
            ServiceDescription = serviceDescription;
        }
    }
}
