using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Exception thrown when User tried to connect whilst already Connecting
    /// </summary>
    public class AlreadyConnectingException : AConnectionException
    {
        public AlreadyConnectingException()
        {}

        public AlreadyConnectingException(string message) : base(message)
        {}

        public AlreadyConnectingException(string message, Exception inner) : base(message, inner)
        {}
    }
}