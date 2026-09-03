using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class InRoomBannerMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public string Extra { get; } // Is JSON

        [ProtoMember(3)]
        public int Position { get; }

        [ProtoMember(4)]
        public int ActionType { get; }
    }
}
