using System;

namespace TikTokLiveSharp.Errors.Permissions
{
    /// <summary>
    /// Exception thrown when User has Insufficient Permissions for Action
    /// </summary>
    public class InsufficientPermissionException : Exception
    {
        public InsufficientPermissionException()
        { }

        public InsufficientPermissionException(string message) : base(message)
        { }

        public InsufficientPermissionException(string message, Exception inner) : base(message, inner)
        { }
    }
}