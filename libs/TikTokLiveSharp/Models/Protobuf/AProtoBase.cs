using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf
{
    /// <summary>
    /// Base-Class for Protobuf-Objects
    /// <para>
    /// Stores any excess Data for potential processing
    /// </para>
    /// </summary>
    public abstract class AProtoBase : IExtensible
    {
        public IExtension _extension;

        public IExtension GetExtensionObject(bool createIfMissing) => Extensible.GetExtensionObject(ref _extension, createIfMissing);
    }
}
