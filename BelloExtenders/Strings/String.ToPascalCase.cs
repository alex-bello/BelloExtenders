using System;
using System.Text.RegularExpressions;

namespace BelloExtenders.Strings
{
    public static partial class ExtensionMethods
    {
        public static string ToPascalCase(this string s)
        {
            return s.Substring(0, 1).ToLower() + s.Substring(1, s.Length - 1);
        }
    }
}