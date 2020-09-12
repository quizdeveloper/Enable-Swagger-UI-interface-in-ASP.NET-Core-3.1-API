using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QDM.CMD.API.Model
{
    public class ResponseData
    {
        public ResponseData()
        {
            StatusCode = 200;
            Messege = "";
            Sucesss = false;
        }
        public int StatusCode { get; set; }
        public string Messege { get; set; }
        public bool Sucesss { get; set; }
    }
}
