using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_Ovf_U1)]
        public static void Conv_Ovf_U1(Context context)
        {
            throw new NotImplementedException("Conv_Ovf_U1 is not implemented");
        }
    }
}
