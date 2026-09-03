using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class GiftDetailsData
    {
        public readonly uint Data1;
        public readonly Text Text2;
        public readonly string Data11;
        public readonly ListUser User21;
        public readonly GiftDataDetailed Details22;

        private GiftDetailsData(Models.Protobuf.UnknownObjects.Data.GiftDetailsData data)
        {
            Data1 = data?.Data1 ?? 0;
            Text2 = data?.Text2;
            Data11 = data?.Data11 ?? string.Empty;
            User21 = data?.User21;
            Details22 = data?.Details22;
        }

        public static implicit operator GiftDetailsData(Models.Protobuf.UnknownObjects.Data.GiftDetailsData data) => new GiftDetailsData(data);
    }
}
