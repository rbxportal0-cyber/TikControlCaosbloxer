using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum NetworkState
    {
        State_Network_Undefined = 0,
        State_Network_Excellent = 1,
        State_Network_Good = 2,
        State_Network_Poor = 3,
        State_Network_Bad = 4,
        State_Network_VBad = 5,
        State_Network_Down = 6
    }
}
