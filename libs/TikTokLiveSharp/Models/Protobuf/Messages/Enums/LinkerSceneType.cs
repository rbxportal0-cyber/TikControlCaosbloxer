using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkerSceneType
    {
        Scene_Unknown = 0,
        Scene_PK = 1,
        Scene_AnchorLinkMic = 2,
        Scene_VirutalPK = 3,
        Scene_AudienceLinkMic = 4,
        Scene_AudioChatRoom = 5,
        Scene_CloudGame = 6,
        Scene_AnchorMultiLinkMic = 7,
        Scene_VideoChatRoom = 8,
        Scene_SocialLinkMic = 9
    }
}
