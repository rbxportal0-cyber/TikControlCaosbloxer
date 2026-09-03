using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Generic Exception thrown for Errors whilst Connecting
    /// </summary>
    public class FailedConnectionException : AConnectionException
    {
        public FailedConnectionException()
        {}

        public FailedConnectionException(string message) : base(message)
        {}

        public FailedConnectionException(string message, Exception inner) : base(message, inner)
        {}
    }
}