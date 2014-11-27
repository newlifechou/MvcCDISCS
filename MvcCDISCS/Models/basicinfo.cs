using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// 基本信息
    /// </summary>
    public class basicinfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string CompanyName { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string Contact { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于80")]
        public string Phone { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string CellPhone { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        public string Fax { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于80")]
        public string Email { get; set; }
        public string Address { get; set; }
        [StringLength(20, ErrorMessage = "长度不能大于20")]
        public string PostCode { get; set; }
    }
}