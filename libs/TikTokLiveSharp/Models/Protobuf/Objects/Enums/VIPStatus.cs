using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum VIPStatus
    {
        VIPStatus_Unknown = 0,
        Renewing = 1,
        RenewSuccess = 2,
        Protective = 3
    }
}
