using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Emote
    {
        /// <summary>
        /// Id for Emote
        /// </summary>
        public readonly string Id;
        public readonly Picture Image;
        public readonly AuditStatus AuditStatus;
        public readonly string Uuid;
        public readonly EmoteType EmoteType;
        public readonly ContentSource ContentSource;
        public readonly EmotePrivateType EmotePrivateType;

        private Emote(Models.Protobuf.Objects.Emote emote)
        {
            Id = emote?.EmoteId ?? string.Empty;
            Image = emote?.Image;
            AuditStatus = emote?.AuditStatus ?? AuditStatus.AuditStatusUnknown;
            Uuid = emote?.Uuid ?? string.Empty;
            EmoteType = emote?.EmoteType ?? EmoteType.EmoteTypeNormal;
            ContentSource = emote?.ContentSource ?? ContentSource.ContentSourceUnknown;
            EmotePrivateType = emote?.EmotePrivateType ?? EmotePrivateType.Emote_Private_Type_Normal;
        }

        public static implicit operator Emote(Models.Protobuf.Objects.Emote emote) => new Emote(emote);
    }
}