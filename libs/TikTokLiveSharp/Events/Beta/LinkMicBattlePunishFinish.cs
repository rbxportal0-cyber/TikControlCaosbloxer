namespace TikTokLiveSharp.Events.Beta
{
    public sealed class LinkMicBattlePunishFinish : AMessageData
    {
        #region InnerTypes
        public sealed class LinkMicBattlePunishFinishData
        {
            public readonly ulong Id2;
            public readonly ulong Timestamp;
            public readonly uint Data3;
            public readonly ulong Id1;
            public readonly uint Data5;
            public readonly uint Data6;
            public readonly uint Data8;

            private LinkMicBattlePunishFinishData(Models.Protobuf.UnknownObjects.LinkMicBattlePunishFinish.LinkMicBattlePunishFinishData data)
            {
                Id2 = data?.Id2 ?? 0;
                Timestamp = data?.Timestamp ?? 0;
                Data3 = data?.Data3 ?? 0;
                Id1 = data?.Id1 ?? 0;
                Data5 = data?.Data5 ?? 0;
                Data6 = data?.Data6 ?? 0;
                Data8 = data?.Data8 ?? 0;
            }

            public static implicit operator LinkMicBattlePunishFinishData(Models.Protobuf.UnknownObjects.LinkMicBattlePunishFinish.LinkMicBattlePunishFinishData data) => new LinkMicBattlePunishFinishData(data);
        }
        #endregion

        public readonly ulong Id1;
        public readonly ulong Timestamp;
        public readonly uint Data4;
        public readonly ulong Id2;
        public readonly LinkMicBattlePunishFinishData Data6;

        internal LinkMicBattlePunishFinish(Models.Protobuf.UnknownObjects.LinkMicBattlePunishFinish msg)
            : base(msg?.Header)
        {
            Id1 = msg?.Id1 ?? 0;
            Timestamp = msg?.Timestamp ?? 0;
            Data4 = msg?.Data4 ?? 0;
            Id2 = msg?.Id2 ?? 0;
            Data6 = msg?.Data6;
        }
    }
}