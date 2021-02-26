using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebParser.Core
{
    class ParserSettings
    {
        public string BaseUrl { get; set; } = "https://habr.com/ru/flows/develop/hubs";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}