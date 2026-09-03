using System;
using System.Threading.Tasks;

namespace TikTokLiveSharp.Client.Socket
{
    /// <summary>
    /// Interface for WebSocket-Connection to TikTok-servers
    /// </summary>
    public interface ITikTokWebSocket
    {
        /// <summary>
        /// Is the websocket currently connected?
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Connect to the websocket
        /// </summary>
        /// <param name="url">Websocket url</param>
        /// <returns>Task to await</returns>
        Task Connect(string url);

        /// <summary>
        /// Disconnects from the websocket
        /// </summary>
        /// <returns>Task to await</returns>
        Task Disconnect();

        /// <summary>
        /// Receives a message from websocket
        /// </summary>
        /// <returns>Task to Await. Result is Response-Message from Socket</returns>
        Task<TikTokWebSocketResponse> ReceiveMessage();

        /// <summary>
        /// Writes a message to the websocket
        /// </summary>
        /// <param name="arr">The bytes to write</param>
        /// <returns>Task to await</returns>
        Task WriteMessage(ArraySegment<byte> arr);
    }
}
