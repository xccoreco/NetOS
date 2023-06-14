using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ckfinite)]
        public static void Ckfinite(Context context)
        {
            throw new NotImplementedException("Ckfinite is not implemented");
        }
    }
}
