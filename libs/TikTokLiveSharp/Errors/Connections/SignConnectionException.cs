using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Exception thrown when an issue arised with the Signing-Server
    /// </summary>
    public class SignConnectionException : AConnectionException
    {
        public SignConnectionException()
        { }

        public SignConnectionException(string message) : base(message)
        { }

        public SignConnectionException(string message, Exception inner) : base(message, inner)
        { }
    }
}