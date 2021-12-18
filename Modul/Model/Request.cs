using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Model
{
    public class Request
    {
        public dynamic Body { get; set; }

        public dynamic header { get; set; }

        public string Url { get; set; }

        public string MetodType { get; set; }
        public string Certificate { get; set; }
    }
}
