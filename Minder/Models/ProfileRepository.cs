using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minder.Models
{
    public class ProfileRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Profile> GetAllProfiles()
        {
            return db.Profiles.ToList();
        }
    }
}