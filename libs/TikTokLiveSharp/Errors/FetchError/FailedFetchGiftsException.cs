using System;

namespace TikTokLiveSharp.Errors.FetchErrors
{
    /// <summary>
    /// Exception thrown if an Error occurred whilst fetching list of Gifts (for Room)
    /// <para>
    /// The session can recover from this Error, but future 
    /// Gift-related events should be considered unreliable.
    /// </para>
    /// </summary>
    public class FailedFetchGiftsException : AFetchException
    {
        public FailedFetchGiftsException()
        { }

        public FailedFetchGiftsException(string message) : base(message)
        { }

        public FailedFetchGiftsException(string message, Exception inner) : base(message, inner)
        { }
    }
}