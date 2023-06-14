using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Constrained)]
        public static void Constrained(Context context)
        {
            throw new NotImplementedException("Constrained is not implemented");
        }
    }
}
