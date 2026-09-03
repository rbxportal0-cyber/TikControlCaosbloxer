using System;
using System.ComponentModel;

namespace TikTokLiveSharp.Client.Config
{
    [Serializable]
    [Flags]
    public enum LogLevel
    {
        /// <summary>
        /// Log Nothing
        /// </summary>
        [Description("Log Nothing")]
        None = 0,

        /// <summary>
        /// Log Errors
        /// </summary>
        [Description("Log Errors")]
        Error = 1,

        /// <summary>
        /// Log Warnings
        /// </summary>
        [Description("Log Warnings")]
        Warning = 2,

        /// <summary>
        /// Log Information
        /// </summary>
        [Description("Log Information")]
        Information = 4,

        /// <summary>
        /// Log Details of Message-Handling
        /// </summary>
        [Description("Log Details of Message-Handling")]
        MessageHandling = 8,

        /// <summary>
        /// Verbose Logging
        /// </summary>
        [Description("Verbose Logging")]
        Verbose = 16
    }
}