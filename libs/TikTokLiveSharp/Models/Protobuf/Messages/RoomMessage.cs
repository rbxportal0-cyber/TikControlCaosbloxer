using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Basic Text Message from Room
    /// </summary>
    [ProtoContract]
    public partial class RoomMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }
        
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(3)]
        public bool SupprotLandscape { get; } // Typo exists in TikTok's Code
        
        [ProtoMember(4)]
        public long Source { get; }
        
        [ProtoMember(5)]
        public Image Icon { get; }
        
        [ProtoMember(6)]
        [DefaultValue("")]
        public string Scene { get; } = string.Empty;

        [ProtoMember(7)]
        public bool IsWelcome { get; }
    }
}
