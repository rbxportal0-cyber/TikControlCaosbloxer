namespace TikTokLiveSharp.Events.Objects
{
    public sealed class DoodleTemplate
    {
        public readonly long TemplateId;
        public readonly Picture Image;

        private DoodleTemplate(Models.Protobuf.Objects.DoodleTemplate template)
        {
            TemplateId = template?.TemplateId ?? -1;
            Image = template?.Image;
        }

        public static implicit operator DoodleTemplate(Models.Protobuf.Objects.DoodleTemplate template) => new DoodleTemplate(template);
    }
}
