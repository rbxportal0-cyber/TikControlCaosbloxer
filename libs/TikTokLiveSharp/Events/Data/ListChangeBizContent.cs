using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ListChangeBizContent
    {
        public readonly IReadOnlyDictionary<long, CohostUserInfo> UserInfos;

        private ListChangeBizContent(Models.Protobuf.Messages.ListChangeBizContent content)
        {
            UserInfos = content?.UserInfosMap?.Count > 0 ? new ReadOnlyDictionary<long, CohostUserInfo>(content.UserInfosMap.ToDictionary(kvp => kvp.Key, kvp => (CohostUserInfo)kvp.Value)) : new ReadOnlyDictionary<long, CohostUserInfo>(new Dictionary<long, CohostUserInfo>(0));
        }

        public static implicit operator ListChangeBizContent(Models.Protobuf.Messages.ListChangeBizContent content) => new ListChangeBizContent(content);
    }
}
