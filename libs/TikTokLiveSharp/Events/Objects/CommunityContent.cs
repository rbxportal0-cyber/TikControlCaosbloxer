using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class CommunityContent
    {
        public readonly CommunityContentType Type;
        public readonly string Text;
        public readonly Picture Image;
        public readonly int DisplayOrder;
        public readonly string TitleTemplateId;

        private CommunityContent(Models.Protobuf.Objects.CommunityContent communityContent)
        {
            Type = communityContent?.CommunityContentType ?? CommunityContentType.CommunityContentTypeUnknown;
            Text = communityContent?.CommunityContentText ?? string.Empty;
            Image = communityContent?.CommunityContentImage;
            DisplayOrder = communityContent?.CommunityContentDisplayOrder ?? -1;
            TitleTemplateId = communityContent?.TitleTemplateId ?? string.Empty;
        }

        public static implicit operator CommunityContent(Models.Protobuf.Objects.CommunityContent communityContent) => new CommunityContent(communityContent);
    }
}
