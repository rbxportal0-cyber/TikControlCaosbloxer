using ProtoBuf;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubPinCardText
    {
        [System.Serializable]
        [ProtoContract]
        public enum TextType
        {
            Unknown = 0,
            Original = 1,
            StarlingKey = 2
        }

        public readonly TextType Type;
        public readonly string Content;

        private SubPinCardText(Models.Protobuf.Objects.SubPinCardText text)
        {
            Type = text?.Type != null ? (TextType)text.Type : TextType.Unknown;
            Content = text?.Content ?? string.Empty;
        }

        private SubPinCardText(Models.Protobuf.Objects.SubPinCard.Text text)
        {
            Type = text?.Type != null ? (TextType)text.Type : TextType.Unknown;
            Content = text?.Content ?? string.Empty;
        }

        public static implicit operator SubPinCardText(Models.Protobuf.Objects.SubPinCardText text) => new SubPinCardText(text);
        public static implicit operator SubPinCardText(Models.Protobuf.Objects.SubPinCard.Text text) => new SubPinCardText(text);
    }
}
