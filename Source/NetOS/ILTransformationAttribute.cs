using dnlib.DotNet.Emit;
using System;

namespace NetOS;

public sealed class ILTransformationAttribute : Attribute
{
    public Code Code;

    public ILTransformationAttribute(Code c) => Code = c;
}