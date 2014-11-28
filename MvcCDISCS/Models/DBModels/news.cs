using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// news
    /// </summary>
    public class news
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Author { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public DateTime PublishTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int ReadCount { get; set; }
        public string Content { get; set; }
    }
}