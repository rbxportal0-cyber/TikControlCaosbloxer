using System.Collections.Generic;
using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ShowInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long ShowStartTime { get; }
        
        [ProtoMember(2)]
        public long ShowEndTime { get; }

        [ProtoMember(3)]
        public List<User> Anchors { get; } = new List<User>();

        [ProtoMember(4)]
        [DefaultValue("")]
        public string ShowIntroduction { get; } = string.Empty;
    }
}
