using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class LinkMicArmiesItems : AProtoBase
    {
        [ProtoMember(1)]
        public ulong HostUserId { get; }

        [ProtoMember(2)]
        public List<LinkMicArmy> BattleGroups { get; } = new List<LinkMicArmy>();
    }
}
