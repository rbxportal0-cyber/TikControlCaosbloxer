using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class LinkMicBattlePunishFinish : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class LinkMicBattlePunishFinishData : AProtoBase
        {
            [ProtoMember(1)]
            public ulong Id2 { get; }

            [ProtoMember(2)]
            public ulong Timestamp { get; }

            [ProtoMember(3)]
            public uint Data3 { get; }

            [ProtoMember(4)]
            public ulong Id1 { get; }

            [ProtoMember(5)]
            public uint Data5 { get; }

            [ProtoMember(6)]
            public uint Data6 { get; }

            [ProtoMember(8)]
            public uint Data8 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ulong Id1 { get; }

        [ProtoMember(3)]
        public ulong Timestamp { get; }

        [ProtoMember(4)]
        public uint Data4 { get; }

        [ProtoMember(5)]
        public ulong Id2 { get; }

        [ProtoMember(6)]
        public LinkMicBattlePunishFinishData Data6 { get; }
    }
}
