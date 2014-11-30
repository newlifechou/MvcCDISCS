using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// productcategory
    /// </summary>
    public class productcategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "类别名称")]
        [Required(ErrorMessage = "不能为空")]
        public string CategoryName { get; set; }
        [Display(Name = "类别图片")]
        [Required(ErrorMessage = "不能为空")]
        public string Photo { get; set; }
        [Display(Name = "类别简介")]
        [Required(ErrorMessage = "不能为空")]
        public string Memo { get; set; }
        [Display(Name = "优先级")]
        [Required(ErrorMessage = "不能为空")]
        public string Priority { get; set; }
        public ICollection<product> Products { get; set; }
    }
}
