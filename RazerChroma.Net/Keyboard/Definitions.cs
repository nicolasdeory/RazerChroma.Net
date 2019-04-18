﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Keyboard
{
    public static class Definitions
    {
        public enum RzKey
        {
            Esc = 0x0001,
            F1 = 0x0003,
            F2 = 0x0004,
            F3 = 0x0005,
            F4 = 0x0006,
            F5 = 0x0007,
            F6 = 0x0008,
            F7 = 0x0009,
            F8 = 0x000A,
            F9 = 0x000B,
            F10 = 0x000C,
            F11 = 0x000D,
            F12 = 0x000E,
            Num1 = 0x0102,
            Num2 = 0x0103,
            Num3 = 0x0104,
            Num4 = 0x0105,
            Num5 = 0x0106,
            Num6 = 0x0107,
            Num7 = 0x0108,
            Num8 = 0x0109,
            Num9 = 0x010A,
            Num0 = 0x010B,
            A = 0x0302,
            B = 0x0407,
            C = 0x0405,
            D = 0x0304,
            E = 0x0204,
            F = 0x0305,
            G = 0x0306,
            H = 0x0307,
            I = 0x0209,
            J = 0x0308,
            K = 0x0309,
            L = 0x030A,
            M = 0x0409,
            N = 0x0408,
            O = 0x020A,
            P = 0x020B,
            Q = 0x0202,
            R = 0x0205,
            S = 0x0303,
            T = 0x0206,
            U = 0x0208,
            V = 0x0406,
            W = 0x0203,
            X = 0x0404,
            Y = 0x0207,
            Z = 0x0403,
            Numlock = 0x0112,
            Numpad0 = 0x0513,
            Numpad1 = 0x0412,
            Numpad2 = 0x0413,
            Numpad3 = 0x0414,
            Numpad4 = 0x0312,
            Numpad5 = 0x0313,
            Numpad6 = 0x0314,
            Numpad7 = 0x0212,
            Numpad8 = 0x0213,
            Numpad9 = 0x0214,
            Numpad_divide = 0x0113,
            Numpad_multiply = 0x0114,
            Numpad_subtract = 0x0115,
            Numpad_add = 0x0215,
            Numpad_enter = 0x0415,
            Numpad_decimal = 0x0514,
            Printscreen = 0x000f,
            Scroll = 0x0010,
            Pause = 0x0011,
            Insert = 0x010f,
            Home = 0x0110,
            Pageup = 0x0111,
            Delete = 0x020f,
            End = 0x0210,
            Pagedown = 0x0211,
            Up = 0x0410,
            Left = 0x050f,
            Down = 0x0510,
            Right = 0x0511,
            Tab = 0x0201,
            Capslock = 0x0301,
            Backspace = 0x010e,
            Enter = 0x030e,
            Lctrl = 0x0501,
            Lwin = 0x0502,
            Lalt = 0x0503,
            Space = 0x0507,
            Ralt = 0x050b,
            Fn = 0x050c,
            Rmenu = 0x050d,
            Rctrl = 0x050e,
            Lshift = 0x0401,
            Rshift = 0x040e,
            Macro1 = 0x0100,
            Macro2 = 0x0200,
            Macro3 = 0x0300,
            Macro4 = 0x0400,
            Macro5 = 0x0500,
            Oem_1 = 0x0101,
            Oem_2 = 0x010c,
            Oem_3 = 0x010d,
            Oem_4 = 0x020c,
            Oem_5 = 0x020d,
            Oem_6 = 0x020e,
            Oem_7 = 0x030b,
            Oem_8 = 0x030c,
            Oem_9 = 0x040a,
            Oem_10 = 0x040b,
            Oem_11 = 0x040c,
            Eur_1 = 0x030d,
            Eur_2 = 0x0402,
            Jpn_1 = 0x0015,
            Jpn_2 = 0x040d,
            Jpn_3 = 0x0504,
            Jpn_4 = 0x0509,
            Jpn_5 = 0x050a,
            Kor_1 = 0x0015,
            Kor_2 = 0x030d,
            Kor_3 = 0x0402,
            Kor_4 = 0x040d,
            Kor_5 = 0x0504,
            Kor_6 = 0x0509,
            Kor_7 = 0x050a,
            Invalid = 0xffff
        }
        public enum RzLed
        {
            Logo = 0x0014
        }
        public enum EffectType
        {
            None = 0,
            Breathing,
            Custom,
            Reactive,
            Static,
            Spectrumcycling,
            Wave,
            Reserved,
            Custom_key,
            Invalid
        }

        public const uint MaxRow = 6;
        public const uint MaxCol = 22;
        public const uint MaxKeys = MaxRow * MaxCol;
        public const uint MaxCustomEffects = MaxKeys;

    }
}
