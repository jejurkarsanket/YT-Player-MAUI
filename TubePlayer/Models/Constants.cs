﻿//Constants File holds all constant/ ReadOnly data.
namespace TubePlayer.Models
{
    //Constants file for storing Read Only data.
    public class Constants
    {
        public static string ApplicationName = "Tube Player";
        public static string EmailAddress = @"tubeplayer@Apps.com";
        public static string ApplicationId = "TubePlayer.App";
        public static string ApiServiceURL = @"https://youtube.googleapis.com/youtube/v3/";
        public static string ApiKey = @"";

        public static uint MicroDuration { get; set; } = 100;
        public static uint SmallDuration { get; set; } = 300;
        public static uint MediumDuration { get; set; } = 600;
        public static uint LongDuration { get; set; } = 1200;
        public static uint ExtraLongDuration { get; set; } = 1800;

    }
}
