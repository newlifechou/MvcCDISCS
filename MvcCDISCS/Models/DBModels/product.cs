using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// 产品详细信息
    /// </summary>
    public class product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name="产品名称")]
        [Required(ErrorMessage = "不能为空")]
        public string ProductName { get; set; }
         [Display(Name = "发布时间")]
        [Required(ErrorMessage = "不能为空")]
        public DateTime PublishTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "阅读次数")]
        public int ReadCount { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "产品照片")]
        public string Photo { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "介绍内容")]
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public virtual productcategory Category { get; set; }
    }
}