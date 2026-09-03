using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicAudienceUserReturnType
    {
        Linkmic_Audience_User_Return_Type_None = 0,
        Linkmic_Audience_User_Return_Type_Private_Msg = 1,
        Linkmic_Audience_User_Return_Type_Deeplink = 2
    }
}
