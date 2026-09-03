using System;

namespace TikTokLiveSharp.Errors.Connections
{
    /// <summary>
    /// Exception thrown when a Room could not be found for a Host
    /// <para>
    /// This usually means the Host is Offline
    /// </para>
    /// </summary>
    public class LiveNotFoundException : AConnectionException
    {
        public LiveNotFoundException()
        {}

        public LiveNotFoundException(string message) : base(message)
        {}

        public LiveNotFoundException(string message, Exception inner) : base(message, inner)
        {}
    }
}