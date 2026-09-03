using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkListStatus
    {
        Status_Unknown = 0,
        Status_Waiting = 1,
        Status_Linked = 2,
        Status_Finished = 3,
        Status_Waiting_Or_Linked = 4
    }
}
