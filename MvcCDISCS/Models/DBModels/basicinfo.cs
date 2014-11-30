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
        [Display(Name = "公司名称")]
        public string CompanyName { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        [Display(Name = "联系人员")]
        public string Contact { get; set; }
        [StringLength(80, ErrorMessage = "长度不能大于80")]
        [Display(Name = "联系电话")]
        public string Phone { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        [Display(Name = "联系手机")]
        public string CellPhone { get; set; }
        [StringLength(50, ErrorMessage = "长度不能大于50")]
        [Display(Name = "传真号码")]
        public string Fax { get; set; }
        [StringLength(80, ErrorMessage = "长度不能大于80")]
        [Display(Name = "电子邮件")]
        public string Email { get; set; }
        [Display(Name = "公司地址")]
        public string Address { get; set; }
        [StringLength(20, ErrorMessage = "长度不能大于20")]
        [Display(Name = "邮政编码")]
        public string PostCode { get; set; }
    }
}