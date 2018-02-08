namespace Minder.Migrations
{
    using Minder.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Minder.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Minder.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Profiles.AddOrUpdate(
              p => p.Nickname,
              new Profile { Nickname = "Andrew Peters", City = "Alkmaar", Gender = GenderEnum.Male, Height = 180, Education = EducationEnum.Highschool, Ethnicity = EthnicityEnum.European, Birthdate = new DateTime(1990, 1, 1), GenderInterests = GenderInterestEnum.Women },
                            new Profile { Nickname = "Andrew Peters", City = "Alkmaar", Gender = GenderEnum.Male, Height = 180, Education = EducationEnum.Highschool, Ethnicity = EthnicityEnum.European, Birthdate = new DateTime(1990, 1, 1), GenderInterests = GenderInterestEnum.Women },
                                                   new Profile { Nickname = "CoderKitten", City = "Utrecht", Gender = GenderEnum.Female, Height = 180, Education = EducationEnum.University, Ethnicity = EthnicityEnum.European, Birthdate = new DateTime(1995, 1, 1), GenderInterests = GenderInterestEnum.Men },
                                                                new Profile { Nickname = "JavaBabe", City = "Schagen", Gender = GenderEnum.Female, Height = 180, Education = EducationEnum.University, Ethnicity = EthnicityEnum.European, Birthdate = new DateTime(1995, 1, 1), GenderInterests = GenderInterestEnum.Men },
                                                   new Profile { Nickname = "Andrea Peters", City = "Alkmaar", Gender = GenderEnum.Female, Height = 180, Education = EducationEnum.Highschool, Ethnicity = EthnicityEnum.European, Birthdate = new DateTime(1990, 1, 1), GenderInterests = GenderInterestEnum.Men }
            );

        }
    }
}
