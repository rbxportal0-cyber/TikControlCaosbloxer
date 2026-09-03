using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerMicIdxUpdateInfo
    {
        public readonly MicIdxOperation Op;
        public readonly long UserId;
        public readonly long MicIdx;

        private LinkerMicIdxUpdateInfo(Models.Protobuf.Messages.LinkerMicIdxUpdateInfo info)
        {
            Op = info?.Op ?? MicIdxOperation.Mic_IDX_Op_On;
            UserId = info?.UserId ?? -1;
            MicIdx = info?.MicIdx ?? -1;
        }

        public static implicit operator LinkerMicIdxUpdateInfo(Models.Protobuf.Messages.LinkerMicIdxUpdateInfo info) => new LinkerMicIdxUpdateInfo(info);
    }
}
