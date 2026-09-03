using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class LinkUserState
    {
        public readonly Player User;
        public readonly string LinkmicId;
        public readonly Position Pos;
        public readonly long LinkedTimeNano;
        public readonly OnlineUserState OnlineUserState;
        public readonly MediaState AudioMuted;
        public readonly MediaState VideoMuted;
        public readonly RtcConnectionState RtcConnection;
        public readonly NetworkState NetworkState;

        private LinkUserState(Models.Protobuf.LinkmicCommon.LinkUserState linkUserState)
        {
            User = linkUserState?.User;
            LinkmicId = linkUserState?.LinkmicId ?? string.Empty;
            Pos = linkUserState?.Pos;
            LinkedTimeNano = linkUserState?.LinkedTimeNano ?? -1;
            OnlineUserState = linkUserState?.OnlineUserState ?? OnlineUserState.State_Undefined;
            AudioMuted = linkUserState?.AudioMuted ?? MediaState.Media_Undefined;
            VideoMuted = linkUserState?.VideoMuted ?? MediaState.Media_Undefined;
            RtcConnection = linkUserState?.RtcConnection ?? RtcConnectionState.State_RTC_Undefined;
            NetworkState = linkUserState?.NetworkState ?? NetworkState.State_Network_Undefined;
        }

        public static implicit operator LinkUserState(Models.Protobuf.LinkmicCommon.LinkUserState linkUserState) => new LinkUserState(linkUserState);
    }
}
