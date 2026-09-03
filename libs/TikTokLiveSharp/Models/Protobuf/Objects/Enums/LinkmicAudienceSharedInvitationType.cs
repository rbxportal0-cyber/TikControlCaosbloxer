using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicAudienceSharedInvitationType
    {
        Linkmic_Audience_Shared_Invitation_Type_None = 0,
        Linkmic_Audience_Shared_Invitation_Type_Normal_Live = 1,
        Linkmic_Audience_Shared_Invitation_Type_Link = 2
    }
}
