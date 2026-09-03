using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class RealBusinessContent : AProtoBase
    {
        public enum BusinessCase
        {
            Business_Not_Set = 0,
            Multi_Live_Content = 100
        }

        public BusinessCase BusinessData => (BusinessCase)oneofBusinessCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofBusinessCase;

        [ProtoMember(1)]
        public long OverLength { get; }

        [ProtoMember(100)]
        public MultiLiveContent MultiLiveContent
        {
            get => oneofBusinessCase.Is(100) ? (MultiLiveContent)oneofBusinessCase.Object : default;
            private set => oneofBusinessCase = new DiscriminatedUnion64Object(100, value);
        }
    }
}
