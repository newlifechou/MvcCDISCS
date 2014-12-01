using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// 用于About的其他内容
    /// </summary>
    public class morebasicinfo
    {
        public int Id { get; set; }
        [Display(Name = "项目名称")]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string ItemName { get; set; }
        [Display(Name = "项目内容")]
        public string ItemContent { get; set; }
    }
}