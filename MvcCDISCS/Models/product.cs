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
        public int ProductId { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public DateTime PublishTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int ReadCount { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Photo { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public virtual productcategory Category { get; set; }
    }
}