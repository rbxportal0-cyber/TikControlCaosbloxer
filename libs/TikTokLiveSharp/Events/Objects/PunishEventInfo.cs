using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PunishEventInfo
    {
        public readonly string Type;
        public readonly string Reason;
        public readonly string Id;
        public readonly long ViolationUid;
        public readonly PunishTypeId TypeId;
        public readonly long Duration;
        public readonly string PerceptionCode;

        private PunishEventInfo(Models.Protobuf.Objects.PunishEventInfo info)
        {
            Type = info?.PunishType ?? string.Empty;
            Reason = info?.PunishReason ?? string.Empty;
            Id = info?.PunishId ?? string.Empty;
            ViolationUid = info?.ViolationUid ?? -1;
            TypeId = info?.PunishTypeId ?? PunishTypeId.PunishTypeIdUnkown;
            Duration = info?.Duration ?? -1;
            PerceptionCode = info?.PunishPerceptionCode ?? string.Empty;
        }

        public static implicit operator PunishEventInfo(Models.Protobuf.Objects.PunishEventInfo info) => new PunishEventInfo(info);
    }
}