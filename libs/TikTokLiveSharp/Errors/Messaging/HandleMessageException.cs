using System;

namespace TikTokLiveSharp.Errors.Messaging
{
    /// <summary>
    /// Exception related to TikTok-Messaging (Parsing/Handling)
    /// </summary>
    public class HandleMessageException : Exception
    {
        public HandleMessageException(string message, Exception inner) : base(message, inner)
        { }
    }
}
