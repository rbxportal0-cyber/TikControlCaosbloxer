using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ContentInviteSource
    {
        Invite_Source_Unknown = 0,
        Invite_Source_Panel_GoLive = 1,
        Invite_Source_Mutual_Notice = 2,
        Invite_Source_User_Profile = 3,
        Invite_Source_Reserve = 4
    }
}
