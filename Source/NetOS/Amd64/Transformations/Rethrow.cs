using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Rethrow)]
        public static void Rethrow(Context context)
        {
            throw new NotImplementedException("Rethrow is not implemented");
        }
    }
}
