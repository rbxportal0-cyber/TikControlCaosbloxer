using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class UserAttr : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsMuted { get; }

        [ProtoMember(2)]
        public bool IsAdmin { get; }

        [ProtoMember(3)]
        public bool IsSuperAdmin { get; }

        [ProtoMember(4)]
        public long MuteDuration { get; }

        [ProtoMember(5)]
        public Dictionary<int, int> AdminPermissionsMap { get; } = new Dictionary<int, int>();
    }
}
