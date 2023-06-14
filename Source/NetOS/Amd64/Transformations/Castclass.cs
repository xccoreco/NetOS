using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Castclass)]
        public static void Castclass(Context context)
        {
            throw new NotImplementedException("Castclass is not implemented");
        }
    }
}
