using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Areas.Administrator.Models
{
    [Serializable]
    public class UserVm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}