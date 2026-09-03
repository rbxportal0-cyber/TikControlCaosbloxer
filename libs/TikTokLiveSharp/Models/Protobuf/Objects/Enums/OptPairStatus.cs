using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum OptPairStatus
    {
        Opt_Pair_Status_Unknown = 0,
        Opt_Pair_Status_Offline = 1,
        Opt_Pair_Status_Finished = 2
    }
}
