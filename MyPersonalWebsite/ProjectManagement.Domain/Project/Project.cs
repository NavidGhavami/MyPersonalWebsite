using _0_Framework.Domain;

namespace ProjectManagement.Domain.Project
{
    public class Project : EntityBase 
    {
        public string Name { get; private set; }
        public string Customer { get; private set; }
        public string Technology { get; private set; }
        public string FirstPicture { get; private set; }
        public string SecondPicture { get; private set; }
        public string ThirdPicture { get; private set; }
        public string ForthPicture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string UrlLink { get; private set; }
        public long CategoryId { get; private set; }
        public string Description { get; private set; }
        public ProjectCategory.ProjectCategory Category { get; private set; }

        public Project(string name, string customer, string technology, string firstPicture, string secondPicture, string thirdPicture,
            string forthPicture, string pictureAlt, string pictureTitle, string slug, string urlLink, long categoryId, string description)
        {
            Name = name;
            Customer = customer;
            Technology = technology;
            FirstPicture = firstPicture;
            SecondPicture = secondPicture;
            ThirdPicture = thirdPicture;
            ForthPicture = forthPicture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            UrlLink = urlLink;
            CategoryId = categoryId;
            Description = description;
        }

        public void Edit(string name, string customer, string technology, string firstPicture, string secondPicture, string thirdPicture,
            string forthPicture, string pictureAlt, string pictureTitle, string slug, string urlLink, long categoryId, string description)
        {
            Name = name;
            Customer = customer;
            Technology = technology;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            UrlLink = urlLink;
            CategoryId = categoryId;
            Description = description;

            if (!string.IsNullOrWhiteSpace(firstPicture))
            {
                FirstPicture = firstPicture;
            }
            if (!string.IsNullOrWhiteSpace(secondPicture))
            {
                SecondPicture = secondPicture;
            }
            if (!string.IsNullOrWhiteSpace(thirdPicture))
            {
                ThirdPicture = thirdPicture;
            }
            if (!string.IsNullOrWhiteSpace(forthPicture))
            {
                ForthPicture = forthPicture;
            }
        }
    }
}
