using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Volatile)]
        public static void Volatile(Context context)
        {
            throw new NotImplementedException("Volatile is not implemented");
        }
    }
}
