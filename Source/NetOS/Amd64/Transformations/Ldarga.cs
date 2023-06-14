using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarga)]
        public static void Ldarga(Context context)
        {
            Ldarg(context);
        }
    }
}
