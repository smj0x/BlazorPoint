/* {﷽‎} */
using dc.Models;
using System;
using System.Collections.Generic;

namespace dc.Constants
{
    public static class Settings
    {
        public static string Title { get; set; }
        public static string LoginName { get; set; }
        public static string LoginNameTrimed = string.Empty;
        public static int Id;
        public static string FormDigestValue { get; set; }
        public static List<Group> Groups { get; set; }
    }
}
