using System;
using System.Net;

namespace TikTokLiveSharp.Client.Config
{
    /// <summary>
    /// Settings for TikTok-Client
    /// </summary>
    [Serializable]
    public struct ClientSettings
    {
        /// <summary>
        /// Timeout for HTTP-Connections (in Seconds)
        /// </summary>
#if UNITY
        [UnityEngine.Header("Settings")]
        [UnityEngine.Tooltip("Timeout for HTTP-Connections (in Seconds)")]
#endif
        public float Timeout;

        /// <summary>
        /// Interval before re-attempting a failed connection
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Interval before re-attempting a failed connection")]
#endif
        public float ReconnectInterval;

        /// <summary>
        /// Polling-Interval for Socket-Connection (in Seconds)
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Polling-Interval for Socket-Connection (in Seconds)")]
#endif
        public float PollingInterval;

        /// <summary>
        /// Enable Compression for Http-Responses
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Enable Compression for Http-Responses")]
#endif
        public bool EnableCompression;

        /// <summary>
        /// Proxy for Connections
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Proxy for Connections")]
#endif
        public IWebProxy Proxy;

        /// <summary>
        /// ISO-Language for Client
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("ISO-Language for Client")]
#endif
        public string ClientLanguage;

        /// <summary>
        /// Size for Buffer for Socket-Connection
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Size for Buffer for Socket-Connection")]
#endif
        public uint SocketBufferSize;

        /// <summary>
        /// Whether to Retry if Connection Fails
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to Retry if Connection Fails")]
#endif
        public bool RetryOnConnectionFailure;

        #region Connecting
        /// <summary>
        /// Set true to skip checking RoomInfo whilst connecting
        /// <para>
        /// Set this true and connect by RoomId if you're having issues connecting by UserId
        /// </para>
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Set true to skip checking RoomInfo whilst connecting")]
#endif
        public bool SkipRoomInfo;

        /// <summary>
        /// Whether to handle Messages received from Room when Connecting
        /// </summary>
#if UNITY
        [UnityEngine.Header("OnConnect")]
        [UnityEngine.Tooltip("Whether to handle Messages received from Room when Connecting")]
#endif
        public bool HandleExistingMessagesOnConnect;

        /// <summary>
        /// Whether to download List of Gifts for Room when Connecting
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to download List of Gifts for Room when Connecting")]
#endif
        public bool DownloadGiftInfo;
        #endregion

        #region Signing
        /// <summary>
        /// API-Key for Signing Server
        /// </summary>
#if UNITY
        [UnityEngine.Header("Signing-Server")]
        [UnityEngine.Tooltip("API-Key for Signing Server")]
#endif
        public string SigningKey;

        /// <summary>
        /// Custom URL for Signing Server
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Custom URL for Signing Server")]
#endif
        public string CustomSigningServerUrl;
        #endregion

        #region Debug
        /// <summary>
        /// Whether to print Logs to Console
        /// </summary>
#if UNITY
        [UnityEngine.Header("Debug")]
        [UnityEngine.Tooltip("Whether to print Logs to Console")]
#endif
        public bool PrintToConsole;

        /// <summary>
        /// LoggingLevel for Logs
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("LoggingLevel for Logs")]
#endif
        public LogLevel LogLevel;

        /// <summary>
        /// Whether to print Base64-Data for Messages to Console
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to print Base64-Data for Messages to Console")]
#endif
        public bool PrintMessageData;

        /// <summary>
        /// Whether to check Messages for Unparsed Data
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to check Messages for Unparsed Data")]
#endif
        public bool CheckForUnparsedData;
        #endregion
    }
}