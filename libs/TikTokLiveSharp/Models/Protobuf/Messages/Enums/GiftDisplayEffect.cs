using ProtoBuf;
using System;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    [Flags]
    public enum GiftDisplayEffect
    {
        Unused = 0,
        Chat = 1,
        Tray = 2,
        Effect = 4
    }
}
