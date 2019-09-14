/* {﷽‎} */
using System;

namespace lms.Constants
{
    public static class Settings
    {
        //Dev-Home
        public static string BaseURL =  "../";
        public static string AttachmentURL = "../../../";
        //Guids
        public static string TasksListGuid = "3AACFFCE-AF80-41B2-860E-3F92C27381EA";
        public static string LicensesListGuid = "3B685950-9EE7-48AF-9D3E-82C88CE93122";
        public static string LicensesListType = "SP.Data.LicensesListItem";

        //Global Variables
        public static string Title { get; set; }
        public static string LoginName { get; set; }
        public static string LoginNameTrimed = string.Empty;
        public static int Id;
        public static string FormDigestValue { get; set; }
        public static string Today = DateTime.Today.Date.ToString();
    }
}
