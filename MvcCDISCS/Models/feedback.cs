using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// feedback
    /// </summary>
    public class feedback
    {
        public int Id { get; set; }
        [Display(Name="标题")]
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "称呼")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "留言时间")]
        public DateTime FeedbackTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "电话")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "内容")]
        public string Content { get; set; }



    }
}