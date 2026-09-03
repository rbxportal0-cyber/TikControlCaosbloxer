using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class LinkMicArmy : AProtoBase
    {
        [ProtoMember(1)]
        public List<LinkMicArmyUser> Users { get; } = new List<LinkMicArmyUser>();

        [ProtoMember(2)]
        public uint Score { get; }
    }
}
