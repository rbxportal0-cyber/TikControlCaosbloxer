using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Base-Class for Exceptions related to the Connection with TikTok-Servers
    /// </summary>
    public abstract class AConnectionException : Exception
    {
        public AConnectionException()
        {}

        public AConnectionException(string message) : base(message)
        {}

        public AConnectionException(string message, Exception inner) : base(message, inner)
        {}
    }
}