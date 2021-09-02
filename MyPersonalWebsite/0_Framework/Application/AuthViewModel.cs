namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string Mobile { get; set; }


        public AuthViewModel()
        {
        }

        public AuthViewModel(long id, long roleId, string fullName, string username, string picture, string mobile)
        {
            Id = id;
            RoleId = roleId;
            FullName = fullName;
            Username = username;
            Mobile = mobile;
            Picture = picture;
            
        }
    }
}