using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Bge_Un)]
        public static void Bge_Un(Context context)
        {
            Bge(context);
        }
    }
}
