using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerUpdateUserContent : AProtoBase
    {
        [ProtoMember(1)]
        public long FromUserId { get; }

        [ProtoMember(2)]
        public long ToUserId { get; }

        [ProtoMember(3)]
        public Dictionary<string, string> UpdateInfoMap { get; } = new Dictionary<string, string>();
    }
}
