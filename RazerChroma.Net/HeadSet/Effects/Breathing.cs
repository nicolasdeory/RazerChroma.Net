using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.HeadSet.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Breathing
    {
        public NativeWin32.ColorRef Color;

        public Breathing(NativeWin32.ColorRef color)
        {
            Color = color;
        }
    }
}