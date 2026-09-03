using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ExhibitionType
    {
        ExhibitionType_Default = 0,
        ExhibitionType_Fold = 1,
        ExhibitionType_PublicScreen = 2
    }
}
