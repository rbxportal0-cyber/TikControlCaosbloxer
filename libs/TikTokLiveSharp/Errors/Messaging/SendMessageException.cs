using System;

namespace TikTokLiveSharp.Errors.Messaging
{
    /// <summary>
    /// Exception related to sending a message to the TikTok-Server
    /// </summary>
    public class SendMessageException : Exception
    {
        public SendMessageException(string message, Exception inner) : base(message, inner)
        { }
    }
}
