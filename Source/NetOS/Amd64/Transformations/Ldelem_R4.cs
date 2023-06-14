using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldelem_R4)]
        public static void Ldelem_R4(Context context)
        {
            throw new NotImplementedException("Ldelem_R4 is not implemented");
        }
    }
}
