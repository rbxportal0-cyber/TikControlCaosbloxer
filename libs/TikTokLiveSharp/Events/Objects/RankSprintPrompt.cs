namespace TikTokLiveSharp.Events.Objects
{
    public sealed class RankSprintPrompt
    {
        public readonly long Countdown;
        public readonly long Duration;
        public readonly Text Content;
        public readonly string BackgroundColor;
        public readonly long GapScore;
        public readonly long OwnerRankIdx;

        private RankSprintPrompt(Models.Protobuf.Objects.RankSprintPrompt prompt)
        {
            Countdown = prompt?.Countdown ?? -1;
            Duration = prompt?.Duration ?? -1;
            Content = prompt?.Content;
            BackgroundColor = prompt?.BackgroundColor ?? string.Empty;
            GapScore = prompt?.GapScore ?? -1;
            OwnerRankIdx = prompt?.OwnerRankIdx ?? -1;
        }

        public static implicit operator RankSprintPrompt(Models.Protobuf.Objects.RankSprintPrompt prompt) => new RankSprintPrompt(prompt);
    }
}