﻿using PCRE.Wrapper;

namespace PCRE
{
    public enum PcreNewLine
    {
        Unknown = 0,
        Cr = NewLine.Cr,
        Lf = NewLine.Lf,
        CrLf = NewLine.CrLf,
        Any = NewLine.Any,
        AnyCrLf = NewLine.AnyCrLf
    }
}
