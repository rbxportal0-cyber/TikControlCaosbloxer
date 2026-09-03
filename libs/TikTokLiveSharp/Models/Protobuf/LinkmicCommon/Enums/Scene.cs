using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum Scene
    {
        Scene_Unknown = 0,
        Scene_Co_Host = 2,
        Scene_Multi_Live = 4
    }
}
