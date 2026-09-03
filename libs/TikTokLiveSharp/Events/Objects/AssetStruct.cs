using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AssetStruct
    {
        public readonly string Name;
        public readonly string ResourceUri;
        public readonly long LegacyEffectId;
        public readonly Picture ResourceUrl;
        public readonly string Description;
        public readonly long Id;
        public readonly int ResourceType;
        public readonly string Md5;
        public readonly long Size;
        public readonly LokiContent LokiContent;
        public readonly int DownloadType;
        public readonly IReadOnlyList<string> ModelRequirements;
        public readonly Picture ResourceByteVc1Url;
        public readonly string ByteVc1Md5;
        public readonly IReadOnlyList<VideoResource> VideoResources;
        public readonly FaceRecognitionArchiveMeta FaceRecognitionArchive;
        public readonly string LynxUrlSettingsKey;
        public readonly int DowngradeResourceType;

        private AssetStruct(Models.Protobuf.Objects.AssetStruct assetStruct)
        {
            Name = assetStruct?.Name ?? string.Empty;
            ResourceUri = assetStruct?.ResourceUri ?? string.Empty;
            LegacyEffectId = assetStruct?.LegacyEffectId ?? -1;
            ResourceUrl = assetStruct?.ResourceUrl;
            Description = assetStruct?.Describe ?? string.Empty;
            Id = assetStruct?.Id ?? -1;
            ResourceType = assetStruct?.ResourceType ?? -1;
            Md5 = assetStruct?.Md5 ?? string.Empty;
            Size = assetStruct?.Size ?? -1;
            LokiContent = assetStruct?.LokiContent;
            DownloadType = assetStruct?.DownloadType ?? -1;
            ModelRequirements = assetStruct?.ModelRequirementsList?.Count > 0 ? new List<string>(assetStruct.ModelRequirementsList).AsReadOnly() : new List<string>(0).AsReadOnly();
            ResourceByteVc1Url = assetStruct?.ResourceByteVc1Url;
            ByteVc1Md5 = assetStruct?.ByteVc1Md5 ?? string.Empty;
            VideoResources = assetStruct?.VideoResourceList?.Count > 0 ? assetStruct.VideoResourceList.Select(r => (VideoResource)r).ToList().AsReadOnly() : new List<VideoResource>(0).AsReadOnly();
            FaceRecognitionArchive = assetStruct?.FaceRecognitionArchiveMeta;
            LynxUrlSettingsKey = assetStruct?.LynxUrlSettingsKey ?? string.Empty;
            DowngradeResourceType = assetStruct?.DowngradeResourceType ?? -1;
        }

        public static implicit operator AssetStruct(Models.Protobuf.Objects.AssetStruct assetStruct) => new AssetStruct(assetStruct);
    }
}
