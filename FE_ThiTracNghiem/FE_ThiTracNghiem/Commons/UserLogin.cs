using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FE_ThiTracNghiem.Commons
{
    [Serializable]
    public class UserLogin
    {
        public string UserID { set; get; }

        public string UserName { set; get; }

        public string Name { set; get; }

        public string[] Roles { set; get; }

        public string TokenAccess { set; get; }

        public string Password { get; set; }
    }
}