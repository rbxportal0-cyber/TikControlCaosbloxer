using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public class LinkerUpdateUserSettingContent
    {
        public readonly LinkmicUserSettingInfo UpdateUserSettingInfo;

        private LinkerUpdateUserSettingContent(Models.Protobuf.Messages.LinkerUpdateUserSettingContent content)
        {
            UpdateUserSettingInfo = content?.UpdateUserSettingInfo;
        }

        public static implicit operator LinkerUpdateUserSettingContent(Models.Protobuf.Messages.LinkerUpdateUserSettingContent content) => new LinkerUpdateUserSettingContent(content);
    }
}
