using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NoEffect
    {
        public Definitions.RzLed LEDId;
    }
}