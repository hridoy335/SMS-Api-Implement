using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace APITesting
{
    public static class StringGenerator
    {
        public static void AppendUrlEncoded(this StringBuilder sb, string name, string value)
        {
            if (sb.Length != 0)
                sb.Append("&");
            sb.Append(HttpUtility.UrlEncode(name));
            sb.Append("=");
            sb.Append(HttpUtility.UrlEncode(value));
        }

    }
}