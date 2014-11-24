using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// admin表-登录用
    /// </summary>
    public class admin
    {
        public int Id { get; set; }
        [Required(ErrorMessage="用户名不能为空")]
        [StringLength(50,ErrorMessage="用户名长度不能大于50")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}