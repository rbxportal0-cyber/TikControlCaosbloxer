using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class RankUpdate : AMessageData
    {
        public sealed class Update
        {
            public sealed class AnimationInfo
            {
                public readonly AnimationInfoType Type;
                public readonly string BackgroundColor;
                public readonly Text Content;
                public readonly long Duration;

                private AnimationInfo(Models.Protobuf.Messages.RankUpdateMessage.RankUpdate.AnimationInfo info)
                {
                    Type = info?.Type ?? AnimationInfoType.NoAnimation;
                    BackgroundColor = info?.BackgroundColor ?? string.Empty;
                    Content = info?.Content;
                    Duration = info?.Duration ?? -1;
                }

                public static implicit operator AnimationInfo(Models.Protobuf.Messages.RankUpdateMessage.RankUpdate.AnimationInfo info) => new AnimationInfo(info);
            }
            
            public readonly RankViewType RankType;
            public readonly long OwnerRank;
            public readonly Text DefaultContent;
            public readonly RankSprintPrompt Prompt;
            public readonly bool ShowEntranceAnimation;
            public readonly long Countdown;
            public readonly AnimationInfo Animation_Info;
            public readonly RankViewType RelatedTabRankType;
            public readonly ShowType RequestFirstShowType;
            public readonly long SupportedVersion;
            public readonly bool OwnerOnRank;

            private Update(Models.Protobuf.Messages.RankUpdateMessage.RankUpdate update)
            {
                RankType = update?.RankType ?? RankViewType.Unknown;
                OwnerRank = update?.OwnerRank ?? -1;
                DefaultContent = update?.DefaultContent;
                Prompt = update?.Prompt;
                ShowEntranceAnimation = update?.ShowEntranceAnimation ?? false;
                Countdown = update?.Countdown ?? -1;
                Animation_Info = update?.Animation_Info;
                RelatedTabRankType = update?.RelatedTabRankType ?? RankViewType.Unknown;
                RequestFirstShowType = update?.RequestFirstShowType ?? ShowType.Hover;
                SupportedVersion = update?.SupportedVersion ?? -1;
                OwnerOnRank = update?.OwnerOnRank ?? false;
            }

            public static implicit operator Update(Models.Protobuf.Messages.RankUpdateMessage.RankUpdate update) => new Update(update);
        }

        public readonly IReadOnlyList<Update> Updates;
        public readonly int GroupType;
        public readonly OpType OpType;
        public readonly long Priority;
        public readonly IReadOnlyList<RankTabInfo> Tabs;
        public readonly bool IsAnimationLoopPlay;
        public readonly bool AnimationLoopForOff;

        internal RankUpdate(Models.Protobuf.Messages.RankUpdateMessage msg)
            : base(msg?.Header)
        {
            Updates = msg?.UpdatesList?.Count > 0 ? msg.UpdatesList.Select(u => (Update)u).ToList().AsReadOnly() : new List<Update>(0).AsReadOnly();
            GroupType = msg?.GroupType ?? -1;
            OpType = msg?.OpType ?? OpType.Op_Type_Default;
            Priority = msg?.Priority ?? -1;
            Tabs = msg?.TabsList?.Count > 0 ? msg.TabsList.Select(t => (RankTabInfo)t).ToList().AsReadOnly() : new List<RankTabInfo>(0).AsReadOnly();
            IsAnimationLoopPlay = msg?.IsAnimationLoopPlay ?? false;
            AnimationLoopForOff = msg?.AnimationLoopForOff ?? false;
        }
    }
}