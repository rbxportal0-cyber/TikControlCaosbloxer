namespace TikTokLiveSharp.Events.Objects
{
    public sealed class HourlyRankSprintPrompt
    {
        public readonly long Countdown;
        public readonly long Duration;
        public readonly Text Content;
        public readonly string BackgroundColor;
        public readonly long GapScore;
        public readonly long OwnerRank;

        private HourlyRankSprintPrompt(Models.Protobuf.Objects.HourlyRankSprintPrompt prompt)
        {
            Countdown = prompt?.Countdown ?? -1;
            Duration = prompt?.Duration ?? -1;
            Content = prompt?.Content;
            BackgroundColor = prompt?.BackgroundColor ?? string.Empty;
            GapScore = prompt?.GapScore ?? -1;
            OwnerRank = prompt?.OwnerRank ?? -1;
        }

        public static implicit operator HourlyRankSprintPrompt(Models.Protobuf.Objects.HourlyRankSprintPrompt prompt) => new HourlyRankSprintPrompt(prompt);
    }
}
