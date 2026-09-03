using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCExtraInfo
    {
        public readonly RTCEngineConfig LiveRTCEngineConfig;
        public readonly IReadOnlyList<RTCLiveVideoParam> LiveRTCVideoParamList;
        public readonly RTCBitrateMap RTCBitrateMap;
        public readonly int RTCFps;
        public readonly RTCMixBase RTCMixBase;
        public readonly ByteRTCExtInfo ByteRTCExtInfo;
        public readonly RTCInfoExtra Extra;
        public readonly string RTCBusinessId;
        public readonly RTCOther RTCOther;
        public readonly int InteractClientType;

        private RTCExtraInfo(Models.Protobuf.LinkmicCommon.RTCExtraInfo rtcExtraInfo)
        {
            LiveRTCEngineConfig = rtcExtraInfo?.LiveRTCEngineConfig;
            LiveRTCVideoParamList = rtcExtraInfo?.LiveRTCVideoParamList?.Count > 0 ? rtcExtraInfo.LiveRTCVideoParamList.Select(p => (RTCLiveVideoParam)p).ToList().AsReadOnly() : new List<RTCLiveVideoParam>(0).AsReadOnly();
            RTCBitrateMap = rtcExtraInfo?.RTCBitrateMap;
            RTCFps = rtcExtraInfo?.RTCFps ?? -1;
            RTCMixBase = rtcExtraInfo?.RTCMixBase;
            ByteRTCExtInfo = rtcExtraInfo?.ByteRTCExtInfo;
            Extra = rtcExtraInfo?.Extra;
            RTCBusinessId = rtcExtraInfo?.RTCBusinessId ?? string.Empty;
            RTCOther = rtcExtraInfo?.RTCOther;
            InteractClientType = rtcExtraInfo?.InteractClientType ?? -1;
        }

        public static implicit operator RTCExtraInfo(Models.Protobuf.LinkmicCommon.RTCExtraInfo rtcExtraInfo) => new RTCExtraInfo(rtcExtraInfo);
    }
}
