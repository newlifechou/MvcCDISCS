﻿using System;
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
        [Required(ErrorMessage="不能为空")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}