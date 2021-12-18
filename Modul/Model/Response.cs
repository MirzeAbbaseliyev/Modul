using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Model
{
    public class Response
    {
        public object Object { get; set; }
        public Result Result { get; set; }

    }


    public class Result
    {
        public string MsgId { get; set; } = "01C9C8DEA76C96DB39DBBBA38C3D4CF7CA6F45E6B97C15BFCC7CD2709EA1FA4D";
        public Success Success { get; set; }
        public Error Error { get; set; }
        public Warning Warning { get; set; }
    }

    public class Success
    {
        public string Code { get; set; } = "200";
        public string Message { get; set; } = "Operation successfully performed";
        public bool Exists { get; set; } = true;
    }

    public class Warning
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public bool Exists { get; set; }
    }
    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public bool Exists { get; set; }
    }
}
