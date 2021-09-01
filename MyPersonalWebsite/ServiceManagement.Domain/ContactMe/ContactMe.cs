using _0_Framework.Domain;

namespace ServiceManagement.Domain.ContactMe
{
    public class ContactMe : EntityBase
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Mobile { get; private set; }
        public string Message { get; private set; }


        public ContactMe(string fullName, string email, string mobile, string message)
        {
            FullName = fullName;
            Email = email;
            Mobile = mobile;
            Message = message;
        }
    }
}
