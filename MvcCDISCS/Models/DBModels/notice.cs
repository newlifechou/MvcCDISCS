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
        [Display(Name = "公告内容")]
        public string NoticeContent { get; set; }
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "优先级")]
        public int Priority { get; set; }
        [Display(Name = "是否显示")]
        public bool IsShow { get; set; }
    }
}