namespace _01_Query.Contract.Project
{
    public class ProjectQueryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Technology { get; set; }
        public string FirstPicture { get; set; }
        public string SecondPicture { get; set; }
        public string ThirdPicture { get; set; }
        public string ForthPicture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string UrlLink { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
