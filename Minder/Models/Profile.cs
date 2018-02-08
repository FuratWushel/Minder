using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Minder.Models
{
    public class Profile
    {
        public int Id { get; set; }

        // Deze property willen we niet in het edit form tonen, daarom scaffoldcolumn(false)
        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Gebruikersnaam")]
        public string Nickname { get; set; }
        [Display(Name = "Geslacht")]
        public GenderEnum Gender { get; set; }

        [Display(Name = "Geïnteresseerd in")]
        public GenderInterestEnum GenderInterests { get; set; }

        // zorgen dat alleen een datum gekozen wordt, geen tijd
        [DataType(DataType.Date)]
        // zorgen dat het format overeenkomt met wat de date control wil, zie http://w3c.github.io/html-reference/input.date.html
        // een alternatieve oplossing die een custom date format mogelijk maakt is het zelf schrijven (niet scaffolden)
        // van de date input control en deze koppelen aan een javascript datepicker
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Lengte (in centimeters)")]
        public int Height { get; set; }
        public EthnicityEnum Ethnicity { get; set; }

        public string City { get; set; }
        public EducationEnum Education { get; set; }

        // Deze property willen we niet in het edit form tonen, daarom scaffoldcolumn(false)
        [ScaffoldColumn(false)]
        public List<Interest> Interests { get; set; }

        [Display(Name = "Profielfoto")]
        // virtual zorgt ervoor dat deze automatisch wordt geladen uit de DB
        public virtual Picture ProfilePicture { get; set; }

        // Deze property willen we niet in het edit form tonen, daarom scaffoldcolumn(false)
        [ScaffoldColumn(false)]
        public List<Picture> Pictures { get; set; }

        // Deze properties willen we niet in het edit form tonen, daarom scaffoldcolumn(false)
        [ScaffoldColumn(false)]
        public int? Openness { get; set; }
        [ScaffoldColumn(false)]
        public int? Conscientiousness { get; set; }
        [ScaffoldColumn(false)]
        public int? Extraversion { get; set; }
        [ScaffoldColumn(false)]
        public int? Agreeableness { get; set; }
        [ScaffoldColumn(false)]
        public int? Neuroticism { get; set; }
    }
}