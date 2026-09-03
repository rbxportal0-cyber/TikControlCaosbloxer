using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class UserAttrResponse
    {
        public readonly IReadOnlyDictionary<long, long> Values;

        private UserAttrResponse(Models.Protobuf.Objects.UserAttrResponse response)
        {
            Values = response?.Values?.Count > 0 ? new ReadOnlyDictionary<long, long>(response.Values) : new ReadOnlyDictionary<long, long>(new Dictionary<long, long>(0));
        }

        public static implicit operator UserAttrResponse(Models.Protobuf.Objects.UserAttrResponse response) => new UserAttrResponse(response);
    }
}
