namespace ServiceManagement.Application.Contract.ContactMe
{
    public class ContactMeViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
        public string CreationDate { get; set; }
    }
}
