using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class RankUpdateMessage : AProtoBase
    {
        [ProtoContract]
        public partial class RankUpdate : AProtoBase
        {
            [ProtoContract]
            public partial class AnimationInfo : AProtoBase
            {
                [ProtoMember(1)] 
                public AnimationInfoType Type { get; }

                [ProtoMember(2)] 
                [DefaultValue("")] 
                public string BackgroundColor { get; } = string.Empty;

                [ProtoMember(3)] 
                public Text Content { get; }

                [ProtoMember(4)] 
                public long Duration { get; }
            }

            [ProtoMember(1)]
            public RankViewType RankType { get; }

            [ProtoMember(2)]
            public long OwnerRank { get; }

            [ProtoMember(3)]
            public Text DefaultContent { get; }

            [ProtoMember(4)]
            public RankSprintPrompt Prompt { get; }
            
            [ProtoMember(5)]
            public bool ShowEntranceAnimation { get; }

            [ProtoMember(6)]
            public long Countdown { get; }

            [ProtoMember(7)]
            public AnimationInfo Animation_Info { get; }

            [ProtoMember(8)]
            public RankViewType RelatedTabRankType { get; }

            [ProtoMember(9)]
            public ShowType RequestFirstShowType { get; }

            [ProtoMember(10)]
            public long SupportedVersion { get; }

            [ProtoMember(11)]
            public bool OwnerOnRank { get; }
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public List<RankUpdate> UpdatesList { get; } = new List<RankUpdate>();

        [ProtoMember(3)]
        public int GroupType { get; } // TODO: IS AN ENUM

        [ProtoMember(4)]
        public OpType OpType { get; }

        [ProtoMember(5)]
        public long Priority { get; }

        [ProtoMember(6)]
        public List<RankTabInfo> TabsList { get; } = new List<RankTabInfo>();

        [ProtoMember(7)]
        public bool IsAnimationLoopPlay { get; }

        [ProtoMember(8)]
        public bool AnimationLoopForOff { get; }
    }
}
