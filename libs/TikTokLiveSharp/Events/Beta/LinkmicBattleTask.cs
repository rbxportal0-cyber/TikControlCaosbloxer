using TikTokLiveSharp.Events.Beta.Data;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class LinkmicBattleTask : AMessageData
    {
        #region InnerTypes
        public sealed class LinkmicBattleTaskData
        {
            public readonly BattleTaskData Data1;

            private LinkmicBattleTaskData(Models.Protobuf.UnknownObjects.LinkmicBattleTaskMessage.LinkmicBattleTaskData data)
            {
                Data1 = data?.Data1;
            }

            public static implicit operator LinkmicBattleTaskData(Models.Protobuf.UnknownObjects.LinkmicBattleTaskMessage.LinkmicBattleTaskData data) => new LinkmicBattleTaskData(data);
        }

        public sealed class LinkmicBattleTaskData2
        {
            public readonly uint Data1;
            public readonly uint Data2;

            private LinkmicBattleTaskData2(Models.Protobuf.UnknownObjects.LinkmicBattleTaskMessage.LinkmicBattleTaskData2 data)
            {
                Data1 = data?.Data1 ?? 0;
                Data2 = data?.Data2 ?? 0;
            }

            public static implicit operator LinkmicBattleTaskData2(Models.Protobuf.UnknownObjects.LinkmicBattleTaskMessage.LinkmicBattleTaskData2 data) => new LinkmicBattleTaskData2(data);
        }
        #endregion

        public readonly uint Data2;
        public readonly LinkmicBattleTaskData Data3;
        public readonly LinkmicBattleTaskData2 Data5;

        internal LinkmicBattleTask(Models.Protobuf.UnknownObjects.LinkmicBattleTaskMessage msg)
            : base(msg?.Header)
        {
            Data2 = msg?.Data2 ?? 0;
            Data3 = msg?.Data3;
            Data5 = msg?.Data5;
        }
    }
}