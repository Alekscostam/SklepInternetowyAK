using SklepInternetowyAK.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepInternetowyAK.DAL
{
    public class FilmsContext : DbContext
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

    }
}