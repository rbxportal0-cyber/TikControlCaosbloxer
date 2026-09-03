using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class RoomPinMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class RoomPinMessageData : AProtoBase
        {
            [ProtoContract]
            public partial class RoomPinMessageDataDetails : AProtoBase
            {
                [ProtoMember(2)]
                public uint Data2 { get; }
            }

            [ProtoMember(1)]
            public ulong Id { get; }

            [ProtoMember(32)]
            public RoomPinMessageDataDetails Data32 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Message that was Pinned
        /// <para>
        /// Usually this is a ChatMessage, but this might also be a GiftMessage?
        /// Use <see cref="OriginalMsgType"/> to Deserialize.
        /// </para>
        /// </summary>
        [ProtoMember(2)]
        public byte[] PinnedMessage { get; }

        [ProtoMember(30)]
        [DefaultValue("")]
        public string OriginalMsgType { get; }

        [ProtoMember(31)]
        public ulong Timestamp { get; }

        [ProtoMember(32)]
        public RoomPinMessageData Data32 { get; }

        [ProtoMember(33)]
        public uint Data33 { get; }

        [ProtoMember(34)]
        public int Data34 { get; }

        [ProtoMember(35)]
        public ulong Data35 { get; }
    }
}
