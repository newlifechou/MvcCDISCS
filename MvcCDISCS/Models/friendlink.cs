using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// friendlink 
    /// </summary>
    public class friendlink
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "长度不能大于20")]
        public string SiteName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string SiteUrl { get; set; }
    }
}