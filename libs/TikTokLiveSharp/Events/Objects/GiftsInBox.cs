using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftsInBox
    {
        public readonly IReadOnlyList<GiftInfoInBox> GiftsInfoInBox;

        private GiftsInBox(Models.Protobuf.Objects.GiftsInBox giftsInBox)
        {
            GiftsInfoInBox = giftsInBox?.GiftsInfoInBoxList?.Count > 0 ? giftsInBox.GiftsInfoInBoxList.Select(g => (GiftInfoInBox)g).ToList().AsReadOnly() : new List<GiftInfoInBox>(0).AsReadOnly();
        }

        public static implicit operator GiftsInBox(Models.Protobuf.Objects.GiftsInBox giftsInBox) => new GiftsInBox(giftsInBox);
    }
}
