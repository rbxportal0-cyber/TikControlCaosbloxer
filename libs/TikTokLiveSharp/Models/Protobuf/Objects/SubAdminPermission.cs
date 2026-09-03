using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubAdminPermission : AProtoBase
    {
        [ProtoMember(1)]
        public bool AllowPinPerk { get; }
    }
}
