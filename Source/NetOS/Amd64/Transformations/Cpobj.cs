using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Cpobj)]
        public static void Cpobj(Context context)
        {
            throw new NotImplementedException("Cpobj is not implemented");
        }
    }
}
