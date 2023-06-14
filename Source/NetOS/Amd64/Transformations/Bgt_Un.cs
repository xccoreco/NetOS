using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Bgt_Un)]
        public static void Bgt_Un(Context context)
        {
            Bgt(context);
        }
    }
}
