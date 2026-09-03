using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum RechargeType
    {
        Recharge_Unknown = 0,
        Recharge_Invite = 1,
        Recharge_Reply = 2,
        Recharge_Group_List = 3
    }
}
