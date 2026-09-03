using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EnvelopeBusinessType {
        BusinessTypeUnknown = 0,
        BusinessTypeUserDiamond = 1,
        BusinessTypePlatformDiamond = 2,
        BusinessTypePlatformShell = 3,
        BusinessTypePortal = 4,
        BusinessTypePlatformMerch = 5,
        BusinessTypeEoYDiamond = 6,
        BusinessTypeFanClubGtM = 7
    }
}
