using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events
{
    public sealed class PartnershipGameOffline : AMessageData
    {
        public sealed class OfflineGameInfo
        {
            [System.Serializable]
            public enum OfflineType
            {
                TaskOffline = 0,
                EventOffline = 1,
                DropsOffline = 2
            }

            public readonly string TaskId;
            public readonly string ToastText;
            public readonly int TaskListLen;
            public readonly OfflineType Offline_Type;

            private OfflineGameInfo(Models.Protobuf.Messages.PartnershipGameOfflineMessage.OfflineGameInfo info)
            {
                TaskId = info?.TaskId ?? string.Empty;
                ToastText = info?.ToastText ?? string.Empty;
                TaskListLen = info?.TaskListLen ?? -1;
                Offline_Type = info?.Offline_Type != null ? (OfflineType)info.Offline_Type : OfflineType.TaskOffline;
            }

            public static implicit operator OfflineGameInfo(Models.Protobuf.Messages.PartnershipGameOfflineMessage.OfflineGameInfo info) => new OfflineGameInfo(info);
        }

        public readonly IReadOnlyList<OfflineGameInfo> OfflineGames;

        internal PartnershipGameOffline(Models.Protobuf.Messages.PartnershipGameOfflineMessage msg)
            : base(msg?.Header)
        {
            OfflineGames = msg?.OfflineGameList?.Count > 0 ? msg.OfflineGameList.Select(info => (OfflineGameInfo)info).ToList().AsReadOnly() : new List<OfflineGameInfo>(0).AsReadOnly();
        }
    }
}