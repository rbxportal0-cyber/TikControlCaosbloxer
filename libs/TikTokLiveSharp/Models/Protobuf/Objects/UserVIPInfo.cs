using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class UserVIPInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long VipLevel { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string VipLevelName { get; } = string.Empty;

        [ProtoMember(3)]
        public VIPStatus Status { get; }

        [ProtoMember(4)]
        public long StartTime { get; }

        [ProtoMember(5)]
        public long EndTime { get; }

        [ProtoMember(6)]
        public long RemainingDays { get; }

        [ProtoMember(7)]
        public long TotalConsume { get; }

        [ProtoMember(8)]
        public long TargetConsume { get; }

        [ProtoMember(9)]
        public VIPBadge Badge { get; }

        [ProtoMember(10)]
        public Dictionary<long, bool> PrivilegesMap { get; }
    }
}
