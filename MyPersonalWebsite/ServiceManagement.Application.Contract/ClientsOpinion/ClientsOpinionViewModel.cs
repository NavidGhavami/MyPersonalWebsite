namespace ServiceManagement.Application.Contract.ClientsOpinion
{
    public class ClientsOpinionViewModel
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public string ClientJob { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}
