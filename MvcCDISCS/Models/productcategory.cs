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
        [Required(ErrorMessage = "不能为空")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Photo { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Memo { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Priority { get; set; }
        public ICollection<product> Products { get; set; }
    }
}
