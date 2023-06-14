using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldelem_I4)]
        public static void Ldelem_I4(Context context)
        {
            DoLdelem(context, 4);
        }
    }
}
