using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgeStruct : AProtoBase
    {
        public enum DataCase
        {
            None = 0,
            Image = 20,
            Text = 21,
            String = 22,
            Combine = 23
        }

        public DataCase BadgeData => (DataCase)oneofDataCase.Discriminator;
        private ProtoBuf.DiscriminatedUnion64Object oneofDataCase;

        [ProtoMember(1)]
        public BadgeDisplayType DisplayType { get; }

        [ProtoMember(2)]
        public BadgePriorityType PriorityType { get; }

        [ProtoMember(3)]
        public BadgeSceneType SceneType { get; }

        /// <summary>
        /// Could also be <see cref="Enums.Position"/>
        /// </summary>
        [ProtoMember(4)]
        public BadgeTextPosition Position { get; }

        [ProtoMember(5)]
        public DisplayStatus DisplayStatus { get; }

        [ProtoMember(6)]
        public long GreyedByClient { get; }

        [ProtoMember(7)]
        public BadgeExhibitionType ExhibitionType { get; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string OpenWebUrl { get; } = string.Empty;

        [ProtoMember(11)]
        public bool Display { get; }

        [ProtoMember(12)]
        public PrivilegeLogExtra PrivilegeLogExtra { get; }

        [ProtoMember(20)]
        public ImageBadge Image 
        {
            get => oneofDataCase.Is(20) ? (ImageBadge)oneofDataCase.Object : default; 
            private set => oneofDataCase = new DiscriminatedUnion64Object(20, value);
        }

        [ProtoMember(21)]
        public TextBadge Text
        {
            get => oneofDataCase.Is(21) ? (TextBadge)oneofDataCase.Object : default; 
            private set => oneofDataCase = new DiscriminatedUnion64Object(21, value);
        }

        [ProtoMember(22)]
        public StringBadge Str
        {
            get => oneofDataCase.Is(22) ? (StringBadge)oneofDataCase.Object : default;
            private set => oneofDataCase = new DiscriminatedUnion64Object(22, value);
        }

        [ProtoMember(23)]
        public CombineBadge Combine
        {
            get => oneofDataCase.Is(23) ? (CombineBadge)oneofDataCase.Object : default;
            private set => oneofDataCase = new DiscriminatedUnion64Object(23, value);
        }
    }
}
