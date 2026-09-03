namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TestDemo
    {
        public readonly string Value;

        private TestDemo(Models.Protobuf.Objects.TestDemo value)
        {
            Value = value?.Value ?? string.Empty;
        }

        public static implicit operator TestDemo(Models.Protobuf.Objects.TestDemo value) => new TestDemo(value);
    }
}
