using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class RankTabInfo
    {
        public readonly RankViewType RankType;
        public readonly string Title;
        public readonly Text TitleText;
        public readonly long ListLynxType;

        private RankTabInfo(Models.Protobuf.Objects.RankTabInfo info)
        {
            RankType = info?.RankType ?? RankViewType.Unknown;
            Title = info?.Title ?? string.Empty;
            TitleText = info?.TitleText;
            ListLynxType = info?.ListLynxType ?? -1;
        }

        public static implicit operator RankTabInfo(Models.Protobuf.Objects.RankTabInfo info) => new RankTabInfo(info);
    }
}