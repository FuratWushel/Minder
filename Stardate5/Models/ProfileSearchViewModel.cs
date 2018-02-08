using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class ProfileSearchViewModel
    {
        public GenderInterestEnum GenderPreference { get; set; }
        public string AgeRange { get; set; }
        public int MinAge
        {
            get
            {
                return Convert.ToInt32(AgeRange.Split(',')[0]);
            }
        }
        public int MaxAge
        {
            get
            {
                return Convert.ToInt32(AgeRange.Split(',')[1]);
            }
        }
        public string HeightRange { get; set; }
        public int HeightMin
        {
            get
            {
                return Convert.ToInt32(HeightRange.Split(',')[0]);
            }
        }
        public int HeightMax
        {
            get
            {
                return Convert.ToInt32(HeightRange.Split(',')[1]);
            }
        }

        [Display(Name = "Ethnicity")]
        public List<EthnicityEnumSelection> EthnicityPreferences { get; set; }
        [Display(Name = "Education")]
        public List<EducationEnumSelection> EducationPreferences { get; set; }

        public string City { get; set; }

        [Display(Name = "Maximum distance from city")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Range must be a number")]
        public int? Range { get; set; } // ? enables null value
    }
}