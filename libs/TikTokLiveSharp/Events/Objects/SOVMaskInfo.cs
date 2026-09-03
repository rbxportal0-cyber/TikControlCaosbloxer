using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public partial class SOVMaskInfo
    {
        public readonly SOVMaskInfoType Type;
        public readonly string Title;

        private SOVMaskInfo(Models.Protobuf.Objects.SOVMaskInfo info)
        {
            Type = info?.Type ?? SOVMaskInfoType.SOV_Mask_Info_Type_None;
            Title = info?.Title ?? string.Empty;
        }

        public static implicit operator SOVMaskInfo(Models.Protobuf.Objects.SOVMaskInfo info) => new SOVMaskInfo(info);
    }
}
