using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class JoinDirectContent
    {
        public readonly LinkLayerListUser Joiner;
        public readonly AllListUser AllUsers;

        private JoinDirectContent(Models.Protobuf.Messages.JoinDirectContent content)
        {
            Joiner = content?.Joiner;
            AllUsers = content?.AllUsers;
        }

        public static implicit operator JoinDirectContent(Models.Protobuf.Messages.JoinDirectContent content) => new JoinDirectContent(content);
    }
}
