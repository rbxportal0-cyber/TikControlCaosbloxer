namespace TikTokLiveSharp.Events.Beta.Data
{
    public sealed class ValueLabel
    {
        public readonly int Data1;
        public readonly string Label2;
        public readonly string Label3;
        public readonly string Label4;

        private ValueLabel(Models.Protobuf.UnknownObjects.Data.ValueLabel lbl)
        {
            Data1 = lbl?.Data1 ?? -1;
            Label2 = lbl?.Label2 ?? string.Empty;
            Label3 = lbl?.Label3 ?? string.Empty;
            Label4 = lbl?.Label4 ?? string.Empty;
        }

        public static implicit operator ValueLabel(Models.Protobuf.UnknownObjects.Data.ValueLabel lbl) => new ValueLabel(lbl);
    }
}
