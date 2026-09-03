namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCOther
    {
        public readonly int MaxTranscodingCbIntervalSecond;

        private RTCOther(Models.Protobuf.LinkmicCommon.RTCOther rtcOther)
        {
            MaxTranscodingCbIntervalSecond = rtcOther?.MaxTranscodingCbIntervalSecond ?? -1;
        }

        public static implicit operator RTCOther(Models.Protobuf.LinkmicCommon.RTCOther rtcOther) => new RTCOther(rtcOther);
    }
}
