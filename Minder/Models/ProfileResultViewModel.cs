using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class ProfileResultViewModel
    {
        public string NickName { get; set; }
        public GenderEnum Gender { get; set; }
        public GenderInterestEnum GenderInterest { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public EthnicityEnum Ethnicity { get; set; }
        public string City { get; set; }
        public EducationEnum Education { get; set; }
        public List<Interest> Interests { get; set; }

        public List<Profile> ProfileResults { get; set; }

        public ProfileResultViewModel()
        {

        }
    }
}