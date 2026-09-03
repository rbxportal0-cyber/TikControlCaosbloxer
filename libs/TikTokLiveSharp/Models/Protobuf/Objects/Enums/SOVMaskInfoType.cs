using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SOVMaskInfoType
    {
        SOV_Mask_Info_Type_None = 0,
        SOV_Mask_Info_Type_Sensitive = 1,
        SOV_Mask_Info_Type_Violation = 2,
        SOV_Mask_Info_Type_Music_Copyright = 3,
        SOV_Mask_Info_Type_Unavailable = 4
    }
}
