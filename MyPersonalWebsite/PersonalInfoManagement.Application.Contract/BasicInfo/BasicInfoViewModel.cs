using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace PersonalInfoManagement.Application.Contract.BasicInfo
{
    public class BasicInfoViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Age { get; set; }
        public string Job { get; set; }
        public string Mobile { get; set; }
        public string CreationDate { get; set; }

    }
}
