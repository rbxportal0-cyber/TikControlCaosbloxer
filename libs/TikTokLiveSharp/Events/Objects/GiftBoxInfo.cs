using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftBoxInfo
    {
        public readonly long Capacity;
        public readonly bool IsPrimaryBox;
        public readonly string SchemeUrl;
        public readonly IReadOnlyList<GiftInfoInBox> GiftInfosInBox;

        private GiftBoxInfo(Models.Protobuf.Objects.GiftBoxInfo info)
        {
            Capacity = info?.Capacity ?? -1;
            IsPrimaryBox = info?.IsPrimaryBox ?? false;
            SchemeUrl = info?.SchemeUrl ?? string.Empty;
            GiftInfosInBox = info?.GiftInfosInBoxList?.Count > 0 ? info.GiftInfosInBoxList.Select(i => (GiftInfoInBox)i).ToList().AsReadOnly() : new List<GiftInfoInBox>(0).AsReadOnly();
        }

        public static implicit operator GiftBoxInfo(Models.Protobuf.Objects.GiftBoxInfo info) => new GiftBoxInfo(info);
    }
}
