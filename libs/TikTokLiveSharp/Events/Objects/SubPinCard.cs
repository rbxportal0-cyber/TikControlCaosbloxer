using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubPinCard
    {
        public readonly long TimeToLive;
        public readonly SubPinCardText Title;
        public readonly SubPinCardText Description;
        public readonly Picture Image;
        public readonly PinCardType Type;
        public readonly long Id;
        public readonly long TemplateId;
        public readonly SubGoalPinCard GoalPinCard;

        private SubPinCard(Models.Protobuf.Objects.SubPinCard subPinCard)
        {
            TimeToLive = subPinCard?.TimeToLive ?? -1;
            Title = subPinCard?.Title;
            Description = subPinCard?.Desc;
            Image = subPinCard?.Image;
            Type = subPinCard?.Type ?? PinCardType.UnknownPinCardType;
            Id = subPinCard?.Id ?? -1;
            TemplateId = subPinCard?.TemplateId ?? -1;
            GoalPinCard = subPinCard?.GoalPinCard;
        }

        public static implicit operator SubPinCard(Models.Protobuf.Objects.SubPinCard subPinCard) => new SubPinCard(subPinCard);
    }
}
