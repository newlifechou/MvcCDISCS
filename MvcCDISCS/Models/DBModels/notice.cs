using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// notice公告
    /// </summary>
    public class notice
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string NoticeContent { get; set; }
        public DateTime CreateTime { get; set; }
        public int Priority { get; set; }
        public bool IsShow { get; set; }
    }
}