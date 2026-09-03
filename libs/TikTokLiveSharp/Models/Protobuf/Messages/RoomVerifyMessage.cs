using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Unknown MessageType. Does not seem to have any (valuable) data.
    /// </summary>
    [ProtoContract]
    public partial class RoomVerifyMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Known Values:
        ///
        /// - 3
        ///
        /// <para>
        /// TODO: This COULD be <see cref="Enums.VerifyAction"/>? (But it's still read as an int by TikTok's Code)
        /// </para>
        /// </summary>
        [ProtoMember(2)]
        public int Action { get; }

        [ProtoMember(3)] 
        [DefaultValue("")] 
        public string Content { get; } = string.Empty;

        [ProtoMember(4)]
        public long NoticeType { get; }

        [ProtoMember(5)]
        public bool CloseRoom { get; }
    }
}
