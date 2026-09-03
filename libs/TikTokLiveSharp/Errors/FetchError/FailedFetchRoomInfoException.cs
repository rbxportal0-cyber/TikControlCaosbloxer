using System;

namespace TikTokLiveSharp.Errors.FetchErrors
{
    /// <summary>
    /// Exception thrown while fetching RoomId for User
    /// <para>
    /// When this Exception is thrown, the RoomID for the entered HostId could not be resolved.
    /// This usually means the host is offline.
    /// </para>
    /// </summary>
    public class FailedFetchRoomInfoException : AFetchException
    {
        public FailedFetchRoomInfoException()
        { }

        public FailedFetchRoomInfoException(string message) : base(message)
        { }

        public FailedFetchRoomInfoException(string message, Exception inner) : base(message, inner)
        { }
    }
}