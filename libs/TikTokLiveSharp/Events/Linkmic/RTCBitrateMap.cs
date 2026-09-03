namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCBitrateMap
    {
        public readonly int XX1;
        public readonly int XX2;
        public readonly int XX3;
        public readonly int XX4;

        private RTCBitrateMap(Models.Protobuf.LinkmicCommon.RTCBitrateMap rtcBitrateMap)
        {
            XX1 = rtcBitrateMap?.XX1 ?? -1;
            XX2 = rtcBitrateMap?.XX2 ?? -1;
            XX3 = rtcBitrateMap?.XX3 ?? -1;
            XX4 = rtcBitrateMap?.XX4 ?? -1;
        }

        public static implicit operator RTCBitrateMap(Models.Protobuf.LinkmicCommon.RTCBitrateMap config) => new RTCBitrateMap(config);
    }
}
