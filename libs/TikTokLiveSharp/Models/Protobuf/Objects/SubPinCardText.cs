using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubPinCardText : AProtoBase
    {
        [ProtoContract]
        [System.Serializable]
        public enum TextType
        {
            Text_Type_Unknown = 0,
            Text_Type_Original = 1,
            Text_Type_Starling_Key = 2
        }

        [ProtoMember(1)]
        public TextType Type { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;
    }
}
