using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldloca)]
        public static void Ldloca(Context context)
        {
            Ldloc(context);
        }
    }
}
