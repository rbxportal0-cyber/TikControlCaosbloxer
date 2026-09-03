using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class BattleTaskData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; }
    }
}
