using _0_Framework.Domain;

namespace ServiceManagement.Domain.ClientsOpinion
{
    public class ClientsOpinion : EntityBase
    {
        public string ClientName { get; private set; }
        public string ClientJob { get; private set; }
        public string Description { get; private set; }
        public bool IsRemoved { get; private set; }


        public ClientsOpinion(string clientName, string clientJob, string description)
        {
            ClientName = clientName;
            ClientJob = clientJob;
            Description = description;
            IsRemoved = false;
        }

        public void Edit(string clientName, string clientJob, string description)
        {
            ClientName = clientName;
            ClientJob = clientJob;
            Description = description;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
