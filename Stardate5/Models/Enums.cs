using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public enum GenderEnum
    {
        Male,
        Female
    }

    public enum GenderInterestEnum
    {
        Women,
        Men,
        Both
    }

    public enum EthnicityEnum
    {
        European,
        Asian,
        African,
        Latino
    }

    public class EthnicityEnumSelection
    {
        public EthnicityEnum Ethnicity { get; set; }
        public bool IsSelected { get; set; }
    }

    public enum EducationEnum
    {
        None,
        [Display(Name = "High school")]
        Highschool,
        University
    }

    public class EducationEnumSelection
    {
        public EducationEnum Education { get; set; }
        public bool IsSelected { get; set; }
    }
}