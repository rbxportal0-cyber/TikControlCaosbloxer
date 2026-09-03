namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class ByteRTCExtInfo
    {
        public readonly int DefaultSignalingServerFirst;

        private ByteRTCExtInfo(Models.Protobuf.LinkmicCommon.ByteRTCExtInfo info)
        {
            DefaultSignalingServerFirst = info?.DefaultSignalingServerFirst ?? -1;
        }

        public static implicit operator ByteRTCExtInfo(Models.Protobuf.LinkmicCommon.ByteRTCExtInfo info) => new ByteRTCExtInfo(info);
    }
}
