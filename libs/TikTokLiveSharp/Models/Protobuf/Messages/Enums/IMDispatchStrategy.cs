using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum IMDispatchStrategy
    {
        IM_Dispatch_Strategy_Default = 0,
        IM_Dispatch_Strategy_Bypass_Dispatch_Queue = 1
    }
}
