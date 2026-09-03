using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class SpecifiedDisplayText
    {
        public readonly long Uid;
        public readonly Text DisplayText;

        private SpecifiedDisplayText(Models.Protobuf.Messages.SpecifiedDisplayText txt)
        {
            Uid = txt?.Uid ?? -1;
            DisplayText = txt?.DisplayText;
        }

        public static implicit operator SpecifiedDisplayText(Models.Protobuf.Messages.SpecifiedDisplayText txt) => new SpecifiedDisplayText(txt);
    }
}
