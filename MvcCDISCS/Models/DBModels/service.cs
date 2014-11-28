using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// service
    /// </summary>
    public class service
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Photo { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Content { get; set; }

    }
}