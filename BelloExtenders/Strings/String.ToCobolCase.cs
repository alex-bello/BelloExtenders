using System;
using System.Text.RegularExpressions;

namespace BelloExtenders.Strings
{
    public static partial class ExtensionMethods
    {
        public static string ToCobolCase(this String s)
        {
            return Regex.Replace(s, ".[A-Z0-9]", match => match.Value[0] + "-" + match.Value[1]).ToLower();
        }
    }
}