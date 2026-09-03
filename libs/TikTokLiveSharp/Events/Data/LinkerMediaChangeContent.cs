using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerMediaChangeContent
    {
        public readonly MicIdxOperation Op;
        public readonly long ToUserId;
        public readonly long HostId;
        public readonly long RoomId;
        public readonly LinkerSceneType ChangeScene;

        private LinkerMediaChangeContent(Models.Protobuf.Messages.LinkerMediaChangeContent content)
        {
            Op = content?.Op ?? MicIdxOperation.Mic_IDX_Op_On;
            ToUserId = content?.ToUserId ?? -1;
            HostId = content?.AnchorId ?? -1;
            RoomId = content?.RoomId ?? -1;
            ChangeScene = content?.ChangeScene ?? LinkerSceneType.Scene_Unknown;
        }

        public static implicit operator LinkerMediaChangeContent(Models.Protobuf.Messages.LinkerMediaChangeContent content) => new LinkerMediaChangeContent(content);
    }
}
