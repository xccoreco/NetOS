using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Refanyval)]
        public static void Refanyval(Context context)
        {
            throw new NotImplementedException("Refanyval is not implemented");
        }
    }
}
