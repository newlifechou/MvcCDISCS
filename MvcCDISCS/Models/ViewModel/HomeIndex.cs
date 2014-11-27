using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCDISCS.Models
{
    public class HomeIndex
    {
        public string PageTitle { get; set; }
        public List<flash> Slides { get; set; }
        public List<notice> Notices { get; set; }
    }
}