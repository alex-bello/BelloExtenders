using System;
using System.Text.RegularExpressions;

namespace BelloExtenders
{
    public static partial class ExtensionMethods
    {
        public static string ToSnakeCase(this String s)
        {
            return Regex.Replace(s, ".[A-Z0-9]", match => match.Value[0] + "_" + match.Value[1]).ToLower();
        }
    }
}