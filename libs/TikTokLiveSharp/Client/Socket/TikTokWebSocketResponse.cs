namespace TikTokLiveSharp.Client.Socket
{
    /// <summary>
    /// Response-Message received from TikTok-Servers
    /// </summary>
    public class TikTokWebSocketResponse
    {
        /// <summary>
        /// Array received from web socket
        /// </summary>
        public readonly byte[] Array;

        /// <summary>
        /// Size of valid Data-Length in Array
        /// </summary>
        public readonly int Count;

        /// <summary>
        /// Creates a TikTok websocket response instance.
        /// </summary>
        /// <param name="array">Response array</param>
        /// <param name="count">Size of Message in Array</param>
        public TikTokWebSocketResponse(byte[] array, int count)
        {
            Array = array;
            Count = count;
        }
    }
}
