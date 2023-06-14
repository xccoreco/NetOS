using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Mkrefany)]
        public static void Mkrefany(Context context)
        {
            throw new NotImplementedException("Mkrefany is not implemented");
        }
    }
}
