using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerEnterContent
    {
        public readonly IReadOnlyList<ListUser> LinkedUsers;
        public readonly LinkmicMultiLiveEnum HostMultiLiveEnum;
        public readonly LinkmicUserSettingInfo HostSettingInfo;

        private LinkerEnterContent(Models.Protobuf.Messages.LinkerEnterContent content)
        {
            LinkedUsers = content?.LinkedUsersList?.Count > 0 ? content.LinkedUsersList.Select(u => (ListUser)u).ToList().AsReadOnly() : new List<ListUser>(0).AsReadOnly();
            HostMultiLiveEnum = content?.AnchorMultiLiveEnum ?? LinkmicMultiLiveEnum.Default;
            HostSettingInfo = content?.AnchorSettingInfo;
        }

        public static implicit operator LinkerEnterContent(Models.Protobuf.Messages.LinkerEnterContent content) => new LinkerEnterContent(content);
    }
}
