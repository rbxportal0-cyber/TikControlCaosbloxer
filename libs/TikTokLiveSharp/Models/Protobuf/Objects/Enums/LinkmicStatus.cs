using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicStatus
    {
        Disable = 0,
        Enable = 1,
        Just_Following = 2,
        Multi_Linking = 3,
        Multi_Linking_Only_Following = 4
    }
}
