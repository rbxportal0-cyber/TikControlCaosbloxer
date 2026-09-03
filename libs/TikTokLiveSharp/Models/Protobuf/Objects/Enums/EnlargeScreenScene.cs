using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EnlargeScreenScene
    {
        Enlarge_Unkown = 0,
        Enlarge_Host_Screen = 1,
        Invite_Enlarge_Guest_Screen = 2,
        Cancel_Enlarge_For_Host = 3,
        Cancel_Enlarge_For_Guest = 4,
        Host_Receive_Cancel_Enlarge = 5,
        Get_Enlarge_Status = 6
    }
}
