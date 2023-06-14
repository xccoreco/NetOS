using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_Ovf_U8_Un)]
        public static void Conv_Ovf_U8_Un(Context context)
        {
            throw new NotImplementedException("Conv_Ovf_U8_Un is not implemented");
        }
    }
}
