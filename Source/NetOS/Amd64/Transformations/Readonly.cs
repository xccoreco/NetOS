using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Readonly)]
        public static void Readonly(Context context)
        {
            throw new NotImplementedException("Readonly is not implemented");
        }
    }
}
