using SklepInternetowyAK.Models;
using System;
using Microsoft.AspNet.Identity.EntityFramework;
using SklepInternetowyAK.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepInternetowyAK.DAL
{
    public class FilmsContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext() : base("FilmsContext")
        {

        }

        static FilmsContext()
        {
            Database.SetInitializer<FilmsContext>(new FilmsInitializer());
        }
        public static FilmsContext Create()
        {
            return new FilmsContext();
        }

    }
}