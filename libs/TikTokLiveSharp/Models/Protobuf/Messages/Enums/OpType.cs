using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum OpType
    {
        Op_Type_Default = 0,
        Op_Type_Add = 1,
        Op_Type_Remove = 2
    }
}
