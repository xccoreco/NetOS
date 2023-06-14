using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stind_Ref)]
        public static void Stind_Ref(Context context)
        {
            throw new NotImplementedException("Stind_Ref is not implemented");
        }
    }
}
