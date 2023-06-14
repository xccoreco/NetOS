using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarga_S)]
        public static void Ldarga_S(Context context)
        {
            Ldarg_S(context);
        }
    }
}
