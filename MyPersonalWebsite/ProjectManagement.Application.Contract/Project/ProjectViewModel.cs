namespace ProjectManagement.Application.Contract.Project
{
    public class ProjectViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string FirstPicture { get; set; }
        public long CategoryId { get; set; }
        public string Category { get; set; }
        public string CreationDate { get; set; }
    }
}
