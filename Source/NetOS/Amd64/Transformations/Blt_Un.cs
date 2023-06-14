using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Blt_Un)]
        public static void Blt_Un(Context context)
        {
            Blt(context);
        }
    }
}
