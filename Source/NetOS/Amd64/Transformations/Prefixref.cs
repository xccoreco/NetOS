using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Prefixref)]
        public static void Prefixref(Context context)
        {
            throw new NotImplementedException("Prefixref is not implemented");
        }
    }
}
