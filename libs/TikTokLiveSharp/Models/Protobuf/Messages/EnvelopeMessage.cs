using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class EnvelopeMessage : AProtoBase
    {
        [ProtoContract]
        public partial class EnvelopeInfo : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string EnvelopeId { get; } = string.Empty;

            [ProtoMember(2)]
            public EnvelopeBusinessType BusinessType { get; }

            [ProtoMember(3)]
            [DefaultValue("")]
            public string EnvelopeIdc { get; } = string.Empty;

            [ProtoMember(4)]
            [DefaultValue("")]
            public string SendUserName { get; } = string.Empty;

            [ProtoMember(5)]
            public int DiamondCount { get; }

            [ProtoMember(6)]
            public int PeopleCount { get; }

            [ProtoMember(7)]
            public int UnpackAt { get; }

            [ProtoMember(8)]
            [DefaultValue("")]
            public string SendUserId { get; } = string.Empty;

            [ProtoMember(9)]
            public Image SendUserAvatar { get; }

            [ProtoMember(10)]
            [DefaultValue("")]
            public string CreateAt { get; } = string.Empty;

            [ProtoMember(11)]
            [DefaultValue("")]
            public string RoomId { get; } = string.Empty;

            [ProtoMember(12)]
            public EnvelopeFollowShowStatus FollowShowStatus { get; }

            [ProtoMember(13)]
            public int SkinId { get; }
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public EnvelopeInfo Envelope_Info { get; }

        [ProtoMember(3)]
        public DisplayStyle Display { get; }
    }
}
