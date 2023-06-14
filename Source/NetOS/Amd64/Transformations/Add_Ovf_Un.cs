using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Add_Ovf_Un)]
        public static void Add_Ovf_Un(Context context)
        {
            throw new NotImplementedException("Add_Ovf_Un is not implemented");
        }
    }
}
