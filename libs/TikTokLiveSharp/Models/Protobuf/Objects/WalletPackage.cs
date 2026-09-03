using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class WalletPackage : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string IapId { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string UsdPriceShow { get; } = string.Empty;
    }
}
