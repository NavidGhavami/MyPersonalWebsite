using System;
using System.Collections.Generic;
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
    }
}
