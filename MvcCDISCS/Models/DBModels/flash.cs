using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// 首页的slide显示内容
    /// </summary>
    public class flash
    {
        public int Id { get; set; }
        [Display(Name = "图片名称")]
        [Required(ErrorMessage = "不能为空")]
        public string SlidePhoto { get; set; }
        [Display(Name = "图片简介")]
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string Memo { get; set; }
        [Display(Name = "优先级别")]
        [Required(ErrorMessage = "不能为空")]
        public int Priority { get; set; }
    }
}