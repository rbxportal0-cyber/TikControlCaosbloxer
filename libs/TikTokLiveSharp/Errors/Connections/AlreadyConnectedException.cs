using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Exception thrown when User tried to connect whilst already Connected
    /// </summary>
    public class AlreadyConnectedException : AConnectionException
    {
        public AlreadyConnectedException()
        {}

        public AlreadyConnectedException(string message) : base(message)
        {}

        public AlreadyConnectedException(string message, Exception inner) : base(message, inner)
        {}
    }
}