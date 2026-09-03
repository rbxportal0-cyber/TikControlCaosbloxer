using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class GiftMonitorInfo : AProtoBase
    {
        /// <summary>
        /// "Anchor" is Host
        /// </summary>
        [ProtoMember(1)]
        public long AnchorId { get; }

        [ProtoMember(2)]
        public long ProfitApiMessageDur { get; }

        [ProtoMember(3)]
        public long SendGiftProfitApiStartMs { get; }

        [ProtoMember(4)]
        public long SendGiftProfitCoreStartMs { get; }

        [ProtoMember(5)]
        public long SendGiftReqStartMs { get; }

        [ProtoMember(6)]
        public long SendGiftSendMessageSuccessMs { get; }

        [ProtoMember(7)]
        public long SendProfitApiDur { get; }

        [ProtoMember(8)]
        public long ToUserId { get; }

        [ProtoMember(9)]
        public long SendGiftStartClientLocalMs { get; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string FromPlatform { get; } = string.Empty;

        [ProtoMember(11)]
        [DefaultValue("")]
        public string FromVersion { get; } = string.Empty;
    }
}
