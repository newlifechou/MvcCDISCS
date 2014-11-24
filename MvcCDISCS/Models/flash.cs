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
        [Required(ErrorMessage = "不能为空")]
        public string SlidePhoto { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string Memo { get; set; }
        public int Priority { get; set; }
    }
}