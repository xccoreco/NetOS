using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Diagnostics;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Starg_S)]
        public static void Starg_S(Context context)
        {
            Starg(context);
        }
    }
}
