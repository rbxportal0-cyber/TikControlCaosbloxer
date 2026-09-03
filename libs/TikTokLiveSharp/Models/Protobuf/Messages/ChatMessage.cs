using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Comment sent by User
    /// </summary>
    [ProtoContract]
    public partial class ChatMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class EmoteWithIndex : AProtoBase
        {
            [ProtoMember(1)]
            public long Index { get; }

            [ProtoMember(2)]
            public Emote Emote { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// User who sent message
        /// </summary>
        [ProtoMember(2)]
        public User User { get; }

        /// <summary>
        /// Text for Chat-Message
        /// </summary>
        [ProtoMember(3)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(4)]
        public bool VisibleToSender { get; }

        [ProtoMember(5)]
        public Image BackgroundImage { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string FullScreenTextColor { get; } = string.Empty;

        [ProtoMember(7)]
        public Image BackgroundImageV2 { get; }

        [ProtoMember(9)]
        public PublicAreaCommon PublicAreaCommon { get; }

        [ProtoMember(10)]
        public Image GiftImage { get; }

        [ProtoMember(11)]
        public int InputType { get; }
        
        [ProtoMember(12)]
        public List<User> MentionedUsers { get; } = new List<User>();
        
        [ProtoMember(13)]
        public List<EmoteWithIndex> EmotesList { get; } = new List<EmoteWithIndex>();

        /// <summary>
        /// Language for sender
        /// </summary>
        [ProtoMember(14)]
        [DefaultValue("")]
        public string ContentLanguage { get; } = string.Empty;

        [ProtoMember(15)]
        public MsgFilter MsgFilter { get; }

        [ProtoMember(16)]
        public int QuickChatScene { get; }

        [ProtoMember(17)]
        public int CommunityFlaggedStatus { get; }

        [ProtoMember(18)]
        public UserIdentity UserIdentity { get; }

        [ProtoMember(19)]
        public List<CommentQualityScore> CommentQualityScores { get; } = new List<CommentQualityScore>();
    }
}
