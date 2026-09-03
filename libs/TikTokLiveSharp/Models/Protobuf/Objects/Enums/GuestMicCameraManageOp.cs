using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GuestMicCameraManageOp
    {
        Open_Mic = 0,
        Open_Camera = 1,
        Close_Mic = 2,
        Close_Camera = 3,
        Close_Mic_Punish = 4
    }
}
