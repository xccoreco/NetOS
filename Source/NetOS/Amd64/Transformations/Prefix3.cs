using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Prefix3)]
        public static void Prefix3(Context context)
        {
            throw new NotImplementedException("Prefix3 is not implemented");
        }
    }
}
