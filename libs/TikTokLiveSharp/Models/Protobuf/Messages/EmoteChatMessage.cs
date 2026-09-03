using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Emote sent by User
    /// </summary>
    [ProtoContract]
    public partial class EmoteChatMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }
        
        [ProtoMember(2)]
        public User User { get; }

        [ProtoMember(3)]
        public List<Emote> EmoteList { get; } = new List<Emote>();

        [ProtoMember(4)]
        public MsgFilter MsgFilter { get; }

        [ProtoMember(5)]
        public UserIdentity UserIdentity { get; }
    }
}
