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
        [Display(Name = "服务名称")]
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Display(Name = "服务图片")]
        [Required(ErrorMessage = "不能为空")]
        public string Photo { get; set; }
        [Display(Name = "服务内容")]
        [Required(ErrorMessage = "不能为空")]
        public string Content { get; set; }

    }
}