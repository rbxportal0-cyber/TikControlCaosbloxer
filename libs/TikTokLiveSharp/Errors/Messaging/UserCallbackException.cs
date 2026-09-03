using System;

namespace TikTokLiveSharp.Errors.Messaging
{
    /// <summary>
    /// Exception Caught in User-Callback
    /// <para>
    /// This Exception is used when handling an Error that was thrown by code 
    /// written by a User of the Library. It envelopes the Exception thrown by the User's code.
    /// </para>
    /// </summary>
    public class UserCallbackException : HandleMessageException
    {
        public UserCallbackException(string message, Exception inner) : base(message, inner)
        { }
    }
}