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
        [Display(Name = "新闻标题")]
        public string Title { get; set; }
        [Display(Name = "新闻来源")]
        [Required(ErrorMessage = "不能为空")]
        public string Author { get; set; }
        [Display(Name = "发布时间")]
        [Required(ErrorMessage = "不能为空")]
        public DateTime PublishTime { get; set; }
        [Display(Name = "阅读次数")]
        [Required(ErrorMessage = "不能为空")]
        public int ReadCount { get; set; }
        [Display(Name="新闻内容")]
        public string Content { get; set; }
    }
}