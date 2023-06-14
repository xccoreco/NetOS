using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.No)]
        public static void No(Context context)
        {
            throw new NotImplementedException("No is not implemented");
        }
    }
}
