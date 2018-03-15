using Common.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class APIResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public dynamic Data { get; set; }
    }
}
