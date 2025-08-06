using System;

namespace SFTG.API;

[Serializable]
public struct Configuration(Configuration.VideoStruct videoStruct)
{
    public VideoStruct Video { get; set; } = videoStruct;

    [Serializable]
    public struct VideoStruct()
    {
        public int Bitrate { get; set; } = 1;
    }
}