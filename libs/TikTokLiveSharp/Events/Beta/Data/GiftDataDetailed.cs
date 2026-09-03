using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class GiftDataDetailed
    {
        public readonly uint Data1;
        public readonly Picture Data2;
        public readonly uint Data3;
        public readonly int Data4;

        private GiftDataDetailed(Models.Protobuf.UnknownObjects.Data.GiftDataDetailed data)
        {
            Data1 = data?.Data1 ?? 0;
            Data2 = data?.Data2;
            Data3 = data?.Data3 ?? 0;
            Data4 = data?.Data4 ?? -1;
        }

        public static implicit operator GiftDataDetailed(Models.Protobuf.UnknownObjects.Data.GiftDataDetailed data) => new GiftDataDetailed(data);
    }
}
