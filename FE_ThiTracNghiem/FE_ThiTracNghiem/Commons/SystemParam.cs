using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FE_ThiTracNghiem.Commons
{
    public class SystemParam
    {
        private string _address;

        public string Address { get => _address; set => _address = value; }

        public SystemParam(string address)
        {
            Address = address;
        }

        public SystemParam()
        {
        }
    }
}