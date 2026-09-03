using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class ProfileContent
    {
        public readonly bool UseContent;
        public readonly IReadOnlyList<IconConfig> Icons;
        public readonly NumberConfig Number_Config;

        private ProfileContent(Models.Protobuf.Objects.ProfileContent content)
        {
            UseContent = content?.UseContent ?? false;
            Icons = content?.IconList?.Count > 0 ? content.IconList.Select(i => (IconConfig)i).ToList().AsReadOnly() : new List<IconConfig>(0).AsReadOnly();
            Number_Config = content?.NumberConfig;
        }

        public static implicit operator ProfileContent(Models.Protobuf.Objects.ProfileContent content) => new ProfileContent(content);
    }
}
