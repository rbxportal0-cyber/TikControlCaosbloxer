using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ControlAction : long
    {
        ControlAction_Unknown = 0,
        Stream_Paused = 1,
        Stream_Upaused = 2,
        Stream_Ended = 3
    }
}
