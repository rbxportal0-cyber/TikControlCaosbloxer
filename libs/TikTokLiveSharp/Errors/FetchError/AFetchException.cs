using System;

namespace TikTokLiveSharp.Errors.FetchErrors
{
    /// <summary>
    /// Base-Class for Exceptions thrown whilst fetching meta-data for a Room
    /// </summary>
    public abstract class AFetchException : Exception
    {
        public AFetchException()
        { }

        public AFetchException(string message) : base(message)
        { }

        public AFetchException(string message, Exception inner) : base(message, inner)
        { }
    }
}
