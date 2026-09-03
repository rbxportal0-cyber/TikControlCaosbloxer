using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum PunishTypeId
    {
        PunishTypeIdUnkown = 0,
        PunishTypeIdBanGamePartnership = 25,
        PunishTypeIdRemoveGamePartnership = 26,
    }
}
