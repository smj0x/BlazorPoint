/* {﷽‎} */
using dc.Models;
using System;
using System.Collections.Generic;

namespace dc.Constants
{
    public static class Settings
    {
        //Title
        public static string AppName = "Datacenter Visitor Log";
        //Paths
        public static string BaseURL =  "../";
        public static string AttachmentURL = "../";
        //Prod
        public static string LogListGuid = "FA478C63-73AF-4DFC-B6FE-F363927FDDD7";
        public static string LogListType = "SP.Data.Log1ListItem";
        //Global Variables
        public static string AdminGroup = "Admins";
        public static string JedOpGroup = "DC-OP-Jeddah";
        public static string DmmOpGroup = "DC-OP-Dammam";
        public static string RydOpGroup = "DC-OP-Riyadh";
        public static string Title { get; set; }
        public static string LoginName { get; set; }
        public static string LoginNameTrimed = string.Empty;
        public static int Id;
        public static string FormDigestValue { get; set; }
        public static List<Group> Groups { get; set; }
    }
}
