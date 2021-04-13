using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SklepInternetowyAK.Models;

namespace SklepInternetowyAK.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Category> Categories { get; set; }

    }
}