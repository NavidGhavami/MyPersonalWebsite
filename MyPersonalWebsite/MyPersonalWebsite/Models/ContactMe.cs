using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models
{
    public class ContactMe
    {
        public int  NameID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AnswerTime { get; set; }

        public ContactMe(int nameId, string address, string email, string phone, string answerTime)
        {
            NameID = nameId;
            Address = address;
            Email = email;
            Phone = phone;
            AnswerTime = answerTime;
        }

        public class ContactForm
        {
            [Required(ErrorMessage = "لطفا نام و نام خانوادگی خود را وارد کنید !")]
            public string FullName { get; set; }

            [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید !")]
            [EmailAddress(ErrorMessage = "ایمیل مورد نظر صحیح نمی باشد !")]
            public string Email { get; set; }

            [Required(ErrorMessage = "لطفا پیغام خود خود را وارد کنید !")]
            public string Message { get; set; }
        }
    }
}
