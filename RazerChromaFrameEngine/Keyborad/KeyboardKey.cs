﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChromaFrameEngine.Keyborad
{
    public enum KeyboradKey
    {
        /// <summary>
        /// The Razer logo on the keyboard.
        /// </summary>
        
        Logo = 0x0014,

        /// <summary>
        /// Esc key.
        /// </summary>
        
        Escape = 0x0001,

        /// <summary>
        /// F1 key.
        /// </summary>
        
        F1 = 0x0003,

        /// <summary>
        /// F2 key.
        /// </summary>
        
        F2 = 0x0004,

        /// <summary>
        /// F3 key.
        /// </summary>
        
        F3 = 0x0005,

        /// <summary>
        /// F4 key.
        /// </summary>
        
        F4 = 0x0006,

        /// <summary>
        /// F5 key.
        /// </summary>
        
        F5 = 0x0007,

        /// <summary>
        /// F6 key.
        /// </summary>
        
        F6 = 0x0008,

        /// <summary>
        /// F7 key.
        /// </summary>
        
        F7 = 0x0009,

        /// <summary>
        /// F8 key.
        /// </summary>
        
        F8 = 0x000A,

        /// <summary>
        /// F9 key.
        /// </summary>
        
        F9 = 0x000B,

        /// <summary>
        /// F10 key.
        /// </summary>
        
        F10 = 0x000C,

        /// <summary>
        /// F11 key.
        /// </summary>
        
        F11 = 0x000D,

        /// <summary>
        /// F12 key.
        /// </summary>
        
        F12 = 0x000E,

        /// <summary>
        /// 1 key.
        /// </summary>
        
        D1 = 0x0102,

        /// <summary>
        /// 2 key.
        /// </summary>
        
        D2 = 0x0103,

        /// <summary>
        /// 3 key.
        /// </summary>
        
        D3 = 0x0104,

        /// <summary>
        /// 4 key.
        /// </summary>
        
        D4 = 0x0105,

        /// <summary>
        /// 5 key.
        /// </summary>
        
        D5 = 0x0106,

        /// <summary>
        /// 6 key.
        /// </summary>
        
        D6 = 0x0107,

        /// <summary>
        /// 7 key.
        /// </summary>
        
        D7 = 0x0108,

        /// <summary>
        /// 8 key.
        /// </summary>
        
        D8 = 0x0109,

        /// <summary>
        /// 9 key.
        /// </summary>
        
        D9 = 0x010A,

        /// <summary>
        /// 0 key.
        /// </summary>
        
        D0 = 0x010B,

        /// <summary>
        /// A key.
        /// </summary>
        
        A = 0x0302,

        /// <summary>
        /// B key.
        /// </summary>
        
        B = 0x0407,

        /// <summary>
        /// C key.
        /// </summary>
        
        C = 0x0405,

        /// <summary>
        /// D key.
        /// </summary>
        
        D = 0x0304,

        /// <summary>
        /// E key.
        /// </summary>
        
        E = 0x0204,

        /// <summary>
        /// F key.
        /// </summary>
        
        F = 0x0305,

        /// <summary>
        /// G key.
        /// </summary>
        
        G = 0x0306,

        /// <summary>
        /// H key.
        /// </summary>
        
        H = 0x0307,

        /// <summary>
        /// I key.
        /// </summary>
        
        I = 0x0209,

        /// <summary>
        /// J key.
        /// </summary>
        
        J = 0x0308,

        /// <summary>
        /// K key.
        /// </summary>
        
        K = 0x0309,

        /// <summary>
        /// L key.
        /// </summary>
        
        L = 0x030A,

        /// <summary>
        /// M key.
        /// </summary>
        
        M = 0x0409,

        /// <summary>
        /// N key.
        /// </summary>
        
        N = 0x0408,

        /// <summary>
        /// O key.
        /// </summary>
        
        O = 0x020A,

        /// <summary>
        /// P key.
        /// </summary>
        
        P = 0x020B,

        /// <summary>
        /// Q key.
        /// </summary>
        
        Q = 0x0202,

        /// <summary>
        /// R key.
        /// </summary>
        
        R = 0x0205,

        /// <summary>
        /// S key.
        /// </summary>
        
        S = 0x0303,

        /// <summary>
        /// T key.
        /// </summary>
        
        T = 0x0206,

        /// <summary>
        /// U key.
        /// </summary>
        
        U = 0x0208,

        /// <summary>
        /// V key.
        /// </summary>
        
        V = 0x0406,

        /// <summary>
        /// W key.
        /// </summary>
        
        W = 0x0203,

        /// <summary>
        /// X key.
        /// </summary>
        
        X = 0x0404,

        /// <summary>
        /// Y key.
        /// </summary>
        
        Y = 0x0207,

        /// <summary>
        /// Z key.
        /// </summary>
        
        Z = 0x0403,

        /// <summary>
        /// Numlock key.
        /// </summary>
        
        NumLock = 0x0112,

        /// <summary>
        /// Numpad 0.
        /// </summary>
        
        Num0 = 0x0513,

        /// <summary>
        /// Numpad 1.
        /// </summary>
        
        Num1 = 0x0412,

        /// <summary>
        /// Numpad 2.
        /// </summary>
        
        Num2 = 0x0413,

        /// <summary>
        /// Numpad 3.
        /// </summary>
        
        Num3 = 0x0414,

        /// <summary>
        /// Numpad 4.
        /// </summary>
        
        Num4 = 0x0312,

        /// <summary>
        /// Numpad 5.
        /// </summary>
        
        Num5 = 0x0313,

        /// <summary>
        /// Numpad 6.
        /// </summary>
        
        Num6 = 0x0314,

        /// <summary>
        /// Numpad 7.
        /// </summary>
        
        Num7 = 0x0212,

        /// <summary>
        /// Numpad 8.
        /// </summary>
        
        Num8 = 0x0213,

        /// <summary>
        /// Numpad 9.
        /// </summary>
        
        Num9 = 0x0214,

        /// <summary>
        /// Divide key.
        /// </summary>
        
        NumDivide = 0x0113,

        /// <summary>
        /// Multiply key.
        /// </summary>
        
        NumMultiply = 0x0114,

        /// <summary>
        /// Subtract key.
        /// </summary>
        
        NumSubtract = 0x0115,

        /// <summary>
        /// Add key.
        /// </summary>
        
        NumAdd = 0x0215,

        /// <summary>
        /// Enter key.
        /// </summary>
        
        NumEnter = 0x0415,

        /// <summary>
        /// Decimal key.
        /// </summary>
        
        NumDecimal = 0x0514,

        /// <summary>
        /// Print Screen.
        /// </summary>
        
        PrintScreen = 0x000F,

        /// <summary>
        /// Scroll Lock.
        /// </summary>
        
        Scroll = 0x0010,

        /// <summary>
        /// Pause key.
        /// </summary>
        
        Pause = 0x0011,

        /// <summary>
        /// Insert key.
        /// </summary>
        
        Insert = 0x010F,

        /// <summary>
        /// Home key.
        /// </summary>
        
        Home = 0x0110,

        /// <summary>
        /// Page Up.
        /// </summary>
        
        PageUp = 0x0111,

        /// <summary>
        /// Delete key.
        /// </summary>
        
        Delete = 0x020f,

        /// <summary>
        /// End key.
        /// </summary>
        
        End = 0x0210,

        /// <summary>
        /// Page Down key.
        /// </summary>
        
        PageDown = 0x0211,

        /// <summary>
        /// Up key.
        /// </summary>
        
        Up = 0x0410,

        /// <summary>
        /// Left key.
        /// </summary>
        
        Left = 0x050F,

        /// <summary>
        /// Down key.
        /// </summary>
        
        Down = 0x0510,

        /// <summary>
        /// Right key.
        /// </summary>
        
        Right = 0x0511,

        /// <summary>
        /// Tab key.
        /// </summary>
        
        Tab = 0x0201,

        /// <summary>
        /// Caps Lock.
        /// </summary>
        
        CapsLock = 0x0301,

        /// <summary>
        /// Backspace key.
        /// </summary>
        
        Backspace = 0x010E,

        /// <summary>
        /// Enter key.
        /// </summary>
        
        Enter = 0x030E,

        /// <summary>
        /// Left control key.
        /// </summary>
        
        LeftControl = 0x0501,

        /// <summary>
        /// Left windows key.
        /// </summary>
        
        LeftWindows = 0x0502,

        /// <summary>
        /// Left alt key.
        /// </summary>
        
        LeftAlt = 0x0503,

        /// <summary>
        /// Spacebar key.
        /// </summary>
        
        Space = 0x0507,

        /// <summary>
        /// Right alt key.
        /// </summary>
        
        RightAlt = 0x050B,

        /// <summary>
        /// "Fn" function key.
        /// </summary>
        
        Function = 0x050C,

        /// <summary>
        /// Right menu key.
        /// </summary>
        
        RightMenu = 0x050D,

        /// <summary>
        /// Right control key.
        /// </summary>
        
        RightControl = 0x050E,

        /// <summary>
        /// Left shift key.
        /// </summary>
        
        
        LeftShift = 0x0401,

        /// <summary>
        /// Right shift key.
        /// </summary>
        
        
        RightShift = 0x040E,

        /// <summary>
        /// Macro key 1.
        /// </summary>
        
        Macro1 = 0x0100,

        /// <summary>
        /// Macro key 2.
        /// </summary>
        
        Macro2 = 0x0200,

        /// <summary>
        /// Macro key 3.
        /// </summary>
        
        Macro3 = 0x0300,

        /// <summary>
        /// Macro key 4.
        /// </summary>
        
        Macro4 = 0x0400,

        /// <summary>
        /// Macro Key 5.
        /// </summary>
        
        Macro5 = 0x0500,

        /// <summary>
        /// Tilde (~) key. 半角/全角.
        /// </summary>
        
        OemTilde = 0x0101,

        /// <summary>
        /// Minus (-) key.
        /// </summary>
        
        OemMinus = 0x010C,

        /// <summary>
        /// Equal sign (=) key.
        /// </summary>
        
        OemEquals = 0x010D,

        /// <summary>
        /// Left square bracket ([) key.
        /// </summary>
        
        OemLeftBracket = 0x020C,

        /// <summary>
        /// Right square bracket (]) key.
        /// </summary>
        
        OemRightBracket = 0x020D,

        /// <summary>
        /// Backslash (\) key.
        /// </summary>
        
        
        OemBackslash = 0x020E,

        /// <summary>
        /// Semi-colon (;) key.
        /// </summary>
        
        OemSemicolon = 0x030B,

        /// <summary>
        /// Apostrophe (') key.
        /// </summary>
        
        OemApostrophe = 0x030C,

        /// <summary>
        /// Comma (,) key.
        /// </summary>
        
        OemComma = 0x040A,

        /// <summary>
        /// Period/full stop (.) key.
        /// </summary>
        
        OemPeriod = 0x040B,

        /// <summary>
        /// Forwards slash (/) key.
        /// </summary>
        
        OemSlash = 0x040C,

        /// <summary>
        /// Pound sign (#) key.
        /// </summary>
        
        
        EurPound = 0x030D,

        /// <summary>
        /// Backslash (\) key.
        /// </summary>
        
        
        EurBackslash = 0x0402,

        /// <summary>
        /// Yen (¥) key.
        /// </summary>
        
        
        JpnYen = 0x0015,

        /// <summary>
        /// Forward slash (/) key.
        /// </summary>
        
        
        JpnSlash = 0x040D,

        /// <summary>
        /// 無変換 key.
        /// </summary>
        
        
        Jpn3 = 0x0504,

        /// <summary>
        /// 変換 key.
        /// </summary>
        
        
        Jpn4 = 0x0509,

        /// <summary>
        /// ひらがな/カタカナ key.
        /// </summary>
        
        
        Jpn5 = 0x050A,

        /// <summary>
        /// Pipe character (|) key.
        /// </summary>
        
        KorPipe = 0x0015,

        /// <summary>
        /// Unknown Korean key.
        /// </summary>
        
        Kor2 = 0x030D,

        /// <summary>
        /// Unknown Korean key.
        /// </summary>
        
        Kor3 = 0x0402,

        /// <summary>
        /// Unknown Korean key.
        /// </summary>
        
        Kor4 = 0x040D,

        /// <summary>
        /// 한자 key.
        /// </summary>
        
        Kor5 = 0x0504,

        /// <summary>
        /// 한/영 key.
        /// </summary>
        
        Kor6 = 0x0509,

        /// <summary>
        /// Unknown Korean key.
        /// </summary>
        
        Kor7 = 0x050A,

        /// <summary>
        /// Invalid key.
        /// </summary>
        
        Invalid = 0xFFFF
    }
}
