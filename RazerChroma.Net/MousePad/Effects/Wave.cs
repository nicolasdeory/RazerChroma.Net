using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Wave
    {
        public enum _Direction
        {
            None = 0,
            LeftToRight,
            RightToLeft,
            Invalid
        }
        public _Direction Direction;
    }
}