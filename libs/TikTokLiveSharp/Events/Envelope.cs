using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events
{
    public sealed class Envelope : AMessageData
    {
        public readonly DisplayStyle Display;
        public readonly string EnvelopeId;
        public readonly EnvelopeBusinessType BusinessType;
        public readonly string EnvelopeIdc;
        public readonly string SendUserName;
        public readonly int DiamondCount;
        public readonly int PeopleCount;
        public readonly int UnpackAt;
        public readonly string SendUserId;
        public readonly Picture SendUserAvatar;
        public readonly string CreateAt;
        public readonly string EnvelopeRoomId;
        public readonly EnvelopeFollowShowStatus FollowShowStatus;
        public readonly int SkinId;

        internal Envelope(Models.Protobuf.Messages.EnvelopeMessage msg)
            : base(msg?.Header)
        {
            Display = msg?.Display ?? DisplayStyle.DisplayStyleNormal;
            EnvelopeId = msg?.Envelope_Info?.EnvelopeId ?? string.Empty;
            BusinessType = msg?.Envelope_Info?.BusinessType ?? EnvelopeBusinessType.BusinessTypeUnknown;
            EnvelopeIdc = msg?.Envelope_Info?.EnvelopeIdc ?? string.Empty;
            SendUserName = msg?.Envelope_Info?.SendUserName ?? string.Empty;
            DiamondCount = msg?.Envelope_Info?.DiamondCount ?? -1;
            PeopleCount = msg?.Envelope_Info?.PeopleCount ?? -1;
            UnpackAt = msg?.Envelope_Info?.UnpackAt ?? -1;
            SendUserId = msg?.Envelope_Info?.SendUserId ?? string.Empty;
            SendUserAvatar = msg?.Envelope_Info?.SendUserAvatar;
            CreateAt = msg?.Envelope_Info?.CreateAt ?? string.Empty;
            EnvelopeRoomId = msg?.Envelope_Info?.RoomId ?? string.Empty;
            FollowShowStatus = msg?.Envelope_Info?.FollowShowStatus ?? EnvelopeFollowShowStatus.EnvelopeFollowShowUnknown;
            SkinId = msg?.Envelope_Info?.SkinId ?? -1;
        }
    }
}