using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Sent for a variety of events, including Follow & Share
    /// </summary>
    [ProtoContract]
    public partial class SocialMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }
        
        /// <summary>
        /// Known as "User" in TikTok's Code
        /// <para>
        /// Can be NULL!
        /// </para>
        /// </summary>
        [ProtoMember(2)]
        public User Sender { get; }

        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        [ProtoMember(3)]
        public long ShareType { get; }

        /// <summary>
        /// Follow - 1
        /// Share - 3
        /// </summary>
        [ProtoMember(4)]
        public long Action { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string ShareTarget { get; } = string.Empty;

        /// <summary>
        /// Exists on Follow-Messages
        /// </summary>
        [ProtoMember(6)]
        public long FollowCount { get; }

        [ProtoMember(7)]
        public long ShareDisplayStyle { get; }

        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        [ProtoMember(8)]
        public long ShareCount { get; }
    }
}
