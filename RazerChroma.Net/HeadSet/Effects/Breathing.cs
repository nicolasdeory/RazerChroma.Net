using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.HeadSet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Breathing
    {
        public NativeWin32.ColorRef Color;
    }
}