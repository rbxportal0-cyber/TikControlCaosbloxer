using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkStateMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long ChannelId { get; }

        [ProtoMember(3)]
        public Scene Scene { get; }

        [ProtoMember(4)]
        public long Version { get; }

        [ProtoMember(5)]
        public int NeedAck { get; }

        [ProtoMember(6)]
        public LayoutState Layout { get; }

        [ProtoMember(7)]
        public List<LinkUserState> UserStatesList { get; } = new List<LinkUserState>();

        [ProtoMember(8)]
        public long ClientSendTime { get; }

        [ProtoMember(9)]
        public StateType StateType { get; }

        [ProtoMember(10)]
        public BackGroundImageState Background { get; }
    }
}
