using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Throw)]
        public static void Throw(Context context)
        {
            throw new NotImplementedException("Throw is not implemented");
        }
    }
}
