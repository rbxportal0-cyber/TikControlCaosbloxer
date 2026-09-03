using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class Request : AProtoBase
    {
        [ProtoMember(1)]
        public long LiveId { get; }

        [ProtoMember(2)]
        public long Aid { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string RoomId { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Identity { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string LastRtt { get; } = string.Empty;

        [ProtoMember(6)]
        [DefaultValue("")]
        public string InternalExt { get; } = string.Empty;

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Cursor { get; } = string.Empty;

        [ProtoMember(8)]
        [DefaultValue("")]
        public string DeviceId { get; } = string.Empty;

        [ProtoMember(9)]
        [DefaultValue("")]
        public string UniqueId { get; } = string.Empty;

        [ProtoMember(10)]
        [DefaultValue("")]
        public string DevicePlatform { get; } = string.Empty;

        [ProtoMember(11)]
        [DefaultValue("")]
        public string AppLanguage { get; } = string.Empty;

        [ProtoMember(12)]
        [DefaultValue("")]
        public string VersionCode { get; } = string.Empty;

        [ProtoMember(13)]
        [DefaultValue("")]
        public string UpdateVersionCode { get; } = string.Empty;

        [ProtoMember(14)]
        [DefaultValue("")]
        public string RespContentType { get; } = string.Empty;

        [ProtoMember(15)]
        [DefaultValue("")]
        public string GetHistory { get; } = string.Empty;

        [ProtoMember(16)]
        [DefaultValue("")]
        public string Ac { get; } = string.Empty;

        [ProtoMember(17)]
        [DefaultValue("")]
        public string KeepMethod { get; } = string.Empty;

        [ProtoMember(18)]
        [DefaultValue("")]
        public string Stress { get; } = string.Empty;

        [ProtoMember(19)]
        public long RecvCnt { get; }

        [ProtoMember(20)]
        public long ParseCnt { get; }

        [ProtoMember(21)]
        [DefaultValue("")]
        public string FetchRule { get; } = string.Empty;

        [ProtoMember(22)]
        [DefaultValue("")]
        public string AbGroup { get; } = string.Empty;

        [ProtoMember(23)]
        public long DidRule { get; }

        [ProtoMember(24)]
        public bool Debug { get; }

        [ProtoMember(25)]
        [DefaultValue("")]
        public string LiveRegion { get; } = string.Empty;

        [ProtoMember(26)]
        [DefaultValue("")]
        public string RoomTag { get; } = string.Empty;

        [ProtoMember(27)]
        [DefaultValue("")]
        public string UserId { get; } = string.Empty;

        [ProtoMember(28)]
        [DefaultValue("")]
        public string ForceHttps { get; } = string.Empty;

        [ProtoMember(29)]
        [DefaultValue("")]
        public string AccountType { get; } = string.Empty;

        [ProtoMember(30)]
        [DefaultValue("")]
        public string WssVersion { get; } = string.Empty;

        [ProtoMember(31)]
        [DefaultValue("")]
        public string HistoryCommentCursor { get; } = string.Empty;
    }
}
