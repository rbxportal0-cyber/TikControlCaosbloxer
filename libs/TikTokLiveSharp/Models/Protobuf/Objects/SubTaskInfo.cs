using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubTaskInfo : AProtoBase
    {
        [ProtoMember(1)]
        public SubUserTask SubUserTask { get; }
    }
}
