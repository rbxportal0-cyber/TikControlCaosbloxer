using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class FaceRecognitionArchiveMeta
    {
        public readonly string Version;
        public readonly IReadOnlyList<string> Requirements;
        public readonly string ModelNames;
        public readonly string SdkExtra;

        private FaceRecognitionArchiveMeta(Models.Protobuf.Objects.FaceRecognitionArchiveMeta archive)
        {
            Version = archive?.Version ?? string.Empty;
            Requirements = archive?.RequirementsList?.Count > 0 ? new List<string>(archive.RequirementsList).AsReadOnly() : new List<string>(0).AsReadOnly();
            ModelNames = archive?.ModelNames ?? string.Empty;
            SdkExtra = archive?.SdkExtra ?? string.Empty;
        }

        public static implicit operator FaceRecognitionArchiveMeta(Models.Protobuf.Objects.FaceRecognitionArchiveMeta archive) => new FaceRecognitionArchiveMeta(archive);
    }
}
