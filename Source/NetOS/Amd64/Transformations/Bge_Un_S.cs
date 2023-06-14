using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Bge_Un_S)]
        public static void Bge_Un_S(Context context)
        {
            Bge(context);
        }
    }
}
