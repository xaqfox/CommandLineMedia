using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommandLineMediaController.CoreAudioAPI
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
    internal interface IAudioMeterInformation
    {
        float GetPeakValue();
    }
}
