using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class LinkmicBattleTaskMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class LinkmicBattleTaskData : AProtoBase
        {
            [ProtoMember(1)]
            public BattleTaskData Data1 { get; }
        }

        [ProtoContract]
        public partial class LinkmicBattleTaskData2 : AProtoBase
        {
            [ProtoMember(1)]
            public uint Data1 { get; }

            [ProtoMember(2)]
            public uint Data2 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public uint Data2 { get; }

        [ProtoMember(3)]
        public LinkmicBattleTaskData Data3 { get; }

        [ProtoMember(5)]
        public LinkmicBattleTaskData2 Data5 { get; }
    }
}
