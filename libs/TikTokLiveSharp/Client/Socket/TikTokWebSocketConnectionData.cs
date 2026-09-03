using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Client.Socket
{
    /// <summary>
    /// Data used to establish a WebSocket-Connection to the TikTok-Server.
    /// </summary>
    public readonly struct TikTokWebSocketConnectionData
    {
        /// <summary>
        /// RoomID for stream to connect to
        /// </summary>
        public readonly string RoomId;
        /// <summary>
        /// TikTokServer-Response obtained from signing-server
        /// </summary>
        public readonly Response InitialWebcastResponse;
        /// <summary>
        /// Headers required for Websocket-Connection
        /// </summary>
        public readonly Dictionary<string, string> CookieHeaders;

        /// <summary>
        /// Creates instance of TikTokWebSocketConnectionData
        /// </summary>
        /// <param name="roomId">RoomID for stream to connect to</param>
        /// <param name="initialResponse">TikTokServer-Response obtained from signing-server</param>
        public TikTokWebSocketConnectionData(string roomId, IEnumerable<string> cookies, Response initialResponse)
        {
            RoomId = roomId;
            InitialWebcastResponse = initialResponse;
            CookieHeaders = new Dictionary<string, string>(cookies.Count());
            foreach (string val in cookies)
            {
                string[] cookieString = val.Split(';');
                foreach (string cookie in cookieString)
                {
                    string[] parsed = cookie.Split('=');
                    CookieHeaders.Add(parsed[0], parsed[1]);
                }
            }
        }
    }
}
