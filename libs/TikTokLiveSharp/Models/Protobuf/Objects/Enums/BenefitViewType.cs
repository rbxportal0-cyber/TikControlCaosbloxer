using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BenefitViewType
    {
        Benefit_View_Type_Unknown = 0,
        Benefit_View_Type_Emote = 1,
        Benefit_View_Type_Badge = 2,
        Benefit_View_Type_Chat = 3,
        Benefit_View_Type_Gift = 4,
        Benefit_View_Type_Customized_Perks = 5,
        Benefit_View_Type_Limited_Content = 6,
        Benefit_View_Type_Discord = 7,
        Benefit_View_Type_Sub_Only_Video = 8
    }
}
