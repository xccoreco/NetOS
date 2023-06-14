using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Sub_Ovf)]
        public static void Sub_Ovf(Context context)
        {
            throw new NotImplementedException("Sub_Ovf is not implemented");
        }
    }
}
