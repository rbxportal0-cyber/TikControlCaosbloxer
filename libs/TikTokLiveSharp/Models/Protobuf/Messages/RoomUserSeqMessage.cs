using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Status of Room (ViewerCount + Top Viewers)
    /// </summary>
    [ProtoContract]
    public partial class RoomUserSeqMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class Contributor : AProtoBase
        {
            /// <summary>
            /// Coins given to Room
            /// </summary>
            [ProtoMember(1)]
            public long Score { get; }

            [ProtoMember(2)]
            public User User { get; }

            /// <summary>
            /// Index in List
            /// </summary>
            [ProtoMember(3)]
            public long Rank { get; }

            [ProtoMember(4)]
            public long Delta { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Top 4 or less
        /// </summary>
        [ProtoMember(2)]
        public List<Contributor> RanksList { get; } = new List<Contributor>();

        /// <summary>
        /// Number of Viewers in Room
        /// </summary>
        [ProtoMember(3)]
        public long Total { get; }

        [ProtoMember(4)] 
        [DefaultValue("")] 
        public string PopStr { get; } = string.Empty;
        
        [ProtoMember(5)]
        public List<Contributor> SeatsList { get; } = new List<Contributor>();
        
        [ProtoMember(6)]
        public long Popularity { get; }
        
        [ProtoMember(7)]
        public long TotalUser { get; }
        
        [ProtoMember(8)]
        public long Anonymous { get; }
    }
}
