using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class RoomNotifyMessage
    {
        #region InnerTypes
        public sealed class NotifyData
        {
            public readonly string Type;
            public readonly string Label;
            public readonly Text Text3;
            public readonly IReadOnlyList<GiftDetailsData> Data4;

            private NotifyData(Models.Protobuf.UnknownObjects.Data.RoomNotifyMessage.NotifyData data)
            {
                Type = data?.Type ?? string.Empty;
                Label = data?.Label ?? string.Empty;
                Text3 = data?.Text3;
                Data4 = data?.Data4?.Count > 0 ? data.Data4.Select(d => (GiftDetailsData)d).ToList().AsReadOnly() : new List<GiftDetailsData>(0).AsReadOnly();
            }

            public static implicit operator NotifyData(Models.Protobuf.UnknownObjects.Data.RoomNotifyMessage.NotifyData data) => new NotifyData(data);
        }
        #endregion

        public readonly string Type;
        public readonly ulong Id1;
        public readonly ulong Id2;
        public readonly ulong Timestamp;
        public readonly NotifyData Data5;

        private RoomNotifyMessage(Models.Protobuf.UnknownObjects.Data.RoomNotifyMessage notify)
        {
            Type = notify?.Type ?? string.Empty;
            Id1 = notify?.Id1 ?? 0;
            Id2 = notify?.Id2 ?? 0;
            Timestamp = notify?.Timestamp ?? 0;
            Data5 = notify?.Data5;
        }

        public static implicit operator RoomNotifyMessage(Models.Protobuf.UnknownObjects.Data.RoomNotifyMessage notify) => new RoomNotifyMessage(notify);
    }
}
