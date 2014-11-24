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
        [Required(ErrorMessage = "不能为空")]
        public string Title { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public DateTime FeedbackTime { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Email { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Content { get; set; }



    }
}