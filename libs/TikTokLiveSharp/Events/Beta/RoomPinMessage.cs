using System;

namespace TikTokLiveSharp.Events.Beta
{
    /// <summary>
    /// Host pinned a message to the room?
    /// </summary>
    public sealed class RoomPinMessage : AMessageData
    {
        #region InnerTypes
        public sealed class RoomPinMessageData
        {
            public sealed class RoomPinMessageDataDetails
            {
                public readonly uint Data2;

                private RoomPinMessageDataDetails(Models.Protobuf.UnknownObjects.RoomPinMessage.RoomPinMessageData.RoomPinMessageDataDetails details)
                {
                    Data2 = details?.Data2 ?? 0;
                }

                public static implicit operator RoomPinMessageDataDetails(Models.Protobuf.UnknownObjects.RoomPinMessage.RoomPinMessageData.RoomPinMessageDataDetails details) => new RoomPinMessageDataDetails(details);
            }

            public readonly ulong Id;
            public readonly RoomPinMessageDataDetails Data32;

            private RoomPinMessageData(Models.Protobuf.UnknownObjects.RoomPinMessage.RoomPinMessageData data)
            {
                Id = data?.Id ?? 0;
                Data32 = data?.Data32;
            }

            public static implicit operator RoomPinMessageData(Models.Protobuf.UnknownObjects.RoomPinMessage.RoomPinMessageData data) => new RoomPinMessageData(data);
        }
        #endregion

        /// <summary>
        /// Message that was Pinned
        /// <para>
        /// Usually this is a ChatMessage, but this might also be a GiftMessage?
        /// Use <see cref="OriginalMsgType"/> to Deserialize.
        /// </para>
        /// </summary>
        public readonly byte[] PinnedMessage;
        public readonly string OriginalMsgType;
        public readonly ulong Timestamp;
        public readonly RoomPinMessageData Data32;
        public readonly uint Data33;
        public readonly int Data34;
        public readonly ulong Data35;

        internal RoomPinMessage(Models.Protobuf.UnknownObjects.RoomPinMessage msg)
            : base(msg?.Header)
        {
            PinnedMessage = msg?.PinnedMessage ?? Array.Empty<byte>();
            OriginalMsgType = msg?.OriginalMsgType ?? string.Empty;
            Timestamp = msg?.Timestamp ?? 0;
            Data32 = msg?.Data32;
            Data33 = msg?.Data33 ?? 0;
            Data34 = msg?.Data34 ?? -1;
            Data35 = msg?.Data35 ?? 0;
        }
    }
}