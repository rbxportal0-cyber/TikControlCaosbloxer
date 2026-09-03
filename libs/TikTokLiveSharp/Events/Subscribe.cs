using System;
using TikTokLiveSharp.Events.Enums;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// User Subscribed to Host
    /// </summary>
    public sealed class Subscribe : AMessageData
    {
        public readonly User User;

        /// <summary>
        /// "Operator" of Room?
        /// <para>
        /// Often NULL
        /// </para>
        /// </summary>
        public readonly User Operator;

        public readonly long ViewerCount;

        public readonly Text HostDisplayText;

        public readonly string EnterSource;

        public readonly string EnterType;

        internal Subscribe(Models.Protobuf.Messages.MemberMessage msg)
            : base(msg?.Header)
        {
            User = msg?.User;
            Operator = msg?.Operator;
            ViewerCount = msg?.MemberCount ?? -1;
            HostDisplayText = msg?.AnchorDisplayText;
            EnterSource = msg?.ClientEnterSource;
            EnterType = msg?.ClientEnterType;
        }
    }
}