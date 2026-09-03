using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class UserAttributes
    {
        public readonly bool IsMuted;
        public readonly bool IsAdmin;
        public readonly bool IsSuperAdmin;
        public readonly long MuteDuration;
        public readonly IReadOnlyDictionary<int, int> AdminPermissions;

        private UserAttributes(Models.Protobuf.Objects.UserAttr attributes)
        {
            IsMuted = attributes?.IsMuted ?? false;
            IsAdmin = attributes?.IsAdmin ?? false;
            IsSuperAdmin = attributes?.IsSuperAdmin ?? false;
            MuteDuration = attributes?.MuteDuration ?? -1;
            AdminPermissions = attributes?.AdminPermissionsMap?.Count > 0
                ? new ReadOnlyDictionary<int, int>(new Dictionary<int, int>(attributes.AdminPermissionsMap))
                : new ReadOnlyDictionary<int, int>(new Dictionary<int, int>(0));
        }

        public static implicit operator UserAttributes(Models.Protobuf.Objects.UserAttr attributes) => new UserAttributes(attributes);
    }
}
