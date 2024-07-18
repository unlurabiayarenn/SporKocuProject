using SporKocu.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public int PremiumPackage  { get; set; }
        public string Phonenumber  { get; set; }
        public string ProfilePicUrl  { get; set; }


    }
}
