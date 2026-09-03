using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class LinkMicArmies : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ulong Id { get; }

        [ProtoMember(3)]
        public List<LinkMicArmiesItems> Data3 { get; } = new List<LinkMicArmiesItems>();

        [ProtoMember(4)]
        public ulong Id2 { get; }

        [ProtoMember(5)]
        public ulong Timestamp5 { get; }

        [ProtoMember(6)]
        public ulong Timestamp6 { get; }

        [ProtoMember(7)]
        public int BattleStatus { get; } // Probably an Enum

        [ProtoMember(8)]
        public ulong Data8 { get; }

        [ProtoMember(9)]
        public ulong Data9 { get; }

        [ProtoMember(10)]
        public uint Data10 { get; }

        [ProtoMember(11)]
        public Image Picture11 { get; }

        [ProtoMember(12)]
        public uint Data12 { get; }

        [ProtoMember(13)]
        public uint Data13 { get; }

        [ProtoMember(17)]
        [DefaultValue("")]
        public string Data17 { get; } = string.Empty;
    }
}
