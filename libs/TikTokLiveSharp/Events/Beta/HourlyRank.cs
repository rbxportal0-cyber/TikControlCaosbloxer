using TikTokLiveSharp.Events.Beta.Data;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class HourlyRank : AMessageData
    {
        #region InnerTypes
        public sealed class RankContainer
        {
            public sealed class RankingData
            {
                public readonly uint Data1;
                public readonly Ranking Data2;
                public readonly string Data3;

                private RankingData(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer.RankingData data)
                {
                    Data1 = data?.Data1 ?? 0;
                    Data2 = data?.Data2;
                    Data3 = data?.Data3 ?? string.Empty;
                }

                public static implicit operator RankingData(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer.RankingData data) => new RankingData(data);
            }

            public sealed class RankingData2
            {
                public readonly uint Data1;
                public readonly uint Data2;
                public readonly Ranking Data3;
                public readonly string Data4;
                public readonly uint Data5;
                public readonly uint Data6;

                private RankingData2(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer.RankingData2 data)
                {
                    Data1 = data?.Data1 ?? 0;
                    Data2 = data?.Data2 ?? 0;
                    Data3 = data?.Data3;
                    Data4 = data?.Data4 ?? string.Empty;
                    Data5 = data?.Data5 ?? 0;
                    Data6 = data?.Data6 ?? 0;
                }

                public static implicit operator RankingData2(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer.RankingData2 data) => new RankingData2(data);
            }

            public readonly uint Data1;
            public readonly RankingData Data2;
            public readonly uint Data3;
            public readonly Ranking Data4;
            public readonly RankingData2 Data5;
            public readonly uint Data6;
            public readonly uint Data7;

            private RankContainer(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer container)
            {
                Data1 = container?.Data1 ?? 0;
                Data2 = container?.Data2;
                Data3 = container?.Data3 ?? 0;
                Data4 = container?.Data4;
                Data5 = container?.Data5;
                Data6 = container?.Data6 ?? 0;
                Data7 = container?.Data7 ?? 0;
            }

            public static implicit operator RankContainer(Models.Protobuf.UnknownObjects.HourlyRankMessage.RankContainer container) => new RankContainer(container);
        }
        #endregion

        public readonly RankContainer Data2;
        public readonly uint Data3;

        internal HourlyRank(Models.Protobuf.UnknownObjects.HourlyRankMessage msg)
            : base(msg?.Header)
        {
            Data2 = msg?.Data2;
            Data3 = msg?.Data3 ?? 0;
        }
    }
}