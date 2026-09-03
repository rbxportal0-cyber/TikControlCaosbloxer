namespace TikTokLiveSharp.Events.Data
{
    public sealed class BoostCard
    {
        public readonly long Id;
        public readonly int TaskSource;
        public readonly long TaskId;

        private BoostCard(Models.Protobuf.Messages.BoostCard boostCard)
        {
            Id = boostCard?.Id ?? -1;
            TaskSource = boostCard?.TaskSource ?? -1;
            TaskId = boostCard?.TaskId ?? -1;
        }

        public static implicit operator BoostCard(Models.Protobuf.Messages.BoostCard boostCard) => new BoostCard(boostCard);
    }
}
