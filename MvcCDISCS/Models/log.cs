using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// log
    /// </summary>
    public class log
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LogTime { get; set; }
        public string IpAddress { get; set; }
        public string Memo { get; set; }
    }
}