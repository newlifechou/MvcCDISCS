using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// career
    /// </summary>
    public class career
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ExpirationTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Content { get; set; }
        public string Memo { get; set; }
        public bool IsShow { get; set; }
    }
}