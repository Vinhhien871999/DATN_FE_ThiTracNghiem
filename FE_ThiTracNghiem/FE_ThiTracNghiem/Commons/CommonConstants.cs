using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FE_ThiTracNghiem.Commons
{
    public class CommonConstants
    {
        public static string USER_SESSION = "USER_SESSION";
        public static string ADMIN_SESSION = "ADMIN_SESSION";
        public static string SESSION_CREDENTIALS = "SESSION_CREDENTIALS";


        /// <summary>
        /// GROUP ROLE IN WEBSITE
        public static string MEMBER_GROUP = "MEMBER";
        public static string ADMIN_GROUP = "ADMIN";
        public static string MOD_GROUP = "MOD";
        public static string SHIP_GROUP = "SHIPPER";
        /// </summary>
        /// 

        //public static string baseAddress = "http://192.168.1.71:7046/api/";
        
        public static string baseAddress = "https://localhost:44309/api/";
    }
}