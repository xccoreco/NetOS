using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Prefix7)]
        public static void Prefix7(Context context)
        {
            throw new NotImplementedException("Prefix7 is not implemented");
        }
    }
}
