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
        [Display(Name="招聘标题")]
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Display(Name = "发布时间")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "过期时间")]
        public DateTime ExpirationTime { get; set; }
        [Display(Name = "招聘要求")]
        [Required(ErrorMessage = "不能为空")]
        public string Content { get; set; }
        [Display(Name = "其他要求")]
        public string Memo { get; set; }
        [Display(Name = "是否显示")]
        public bool IsShow { get; set; }
    }
}