using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TrOCR.Helper
{
    class YoudaoHelper
    {
        public static string GetMD5LastString()
        {
            string html = CommonHelper.GetHtmlContent("https://shared.ydstatic.com/fanyi/newweb/v1.1.8/scripts/newweb/fanyi.min.js");
            string pattern = @"""fanyideskweb""\+e\+i\+""(.*?)""";
            Match m1 = Regex.Match(html, pattern);
            string last = String.Empty;
            if (m1.Success)
            {
                last = m1.Groups[1].Value;
            }
            return last;
        }
    }
}
