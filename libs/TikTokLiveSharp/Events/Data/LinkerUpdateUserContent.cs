using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerUpdateUserContent
    {
        public readonly long FromUserId;
        public readonly long ToUserId;
        public readonly IReadOnlyDictionary<string, string> UpdateInfo;

        private LinkerUpdateUserContent(Models.Protobuf.Messages.LinkerUpdateUserContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            ToUserId = content?.ToUserId ?? -1;
            UpdateInfo = content?.UpdateInfoMap?.Count > 0 ? new ReadOnlyDictionary<string, string>(content?.UpdateInfoMap) : new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(0));
        }

        public static implicit operator LinkerUpdateUserContent(Models.Protobuf.Messages.LinkerUpdateUserContent content) => new LinkerUpdateUserContent(content);
    }
}
