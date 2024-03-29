﻿using System.Text.RegularExpressions;

namespace Maui.Apps.Framework.Extensions
{
    public static class StringExtensions
    {
        //Cleaning out Cache Key.
        public static string CleanCacheKey(this string uri) =>
            Regex.Replace((new Regex("[\\~#%&*{}/:<>?|\"-]")).Replace(uri, " "), @"\s+","_");
    }
}
