using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GameTag : AProtoBase
    {
        [ProtoContract]
        [System.Serializable]
        public enum GameTagType
        {
            Unknown = 0,
            PCGame = 1,
            MobileGame = 2,
            ConsoleGame = 3
        }

        [ProtoContract]
        public partial class GameTagCategory : AProtoBase
        {
            [ProtoMember(1)]
            public GameTagType GameType { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Title { get; } = string.Empty;
        }

        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ShowName { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string ShortName { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string FullName { get; } = string.Empty;

        [ProtoMember(5)]
        public List<long> HashtagIdList { get; } = new List<long>();

        [ProtoMember(6)]
        public List<Hashtag> HashtagList { get; } = new List<Hashtag>();

        [ProtoMember(7)]
        public List<GameTagCategory> GameCategoryList { get; } = new List<GameTagCategory>();

        [ProtoMember(8)]
        public long Landscape { get; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string PackageName { get; } = string.Empty;

        [ProtoMember(10)]
        [DefaultValue("")]
        public string BundleId { get; } = string.Empty;
    }
}
