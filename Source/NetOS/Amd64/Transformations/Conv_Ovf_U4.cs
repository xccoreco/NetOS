using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_Ovf_U4)]
        public static void Conv_Ovf_U4(Context context)
        {
            throw new NotImplementedException("Conv_Ovf_U4 is not implemented");
        }
    }
}
