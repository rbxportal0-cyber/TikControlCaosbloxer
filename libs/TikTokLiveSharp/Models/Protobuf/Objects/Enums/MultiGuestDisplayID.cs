using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum MultiGuestDisplayID
    {
        Multi_Guest_Display_Id_None = 0,
        Multi_Guest_Display_Id_Full_Screen = 1,
        Multi_Guest_Display_Id_Fixed = 2,
        Multi_Guest_Display_Id_Float = 3
    }
}
