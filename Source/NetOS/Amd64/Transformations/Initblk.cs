using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Initblk)]
        public static void Initblk(Context context)
        {
            throw new NotImplementedException("Initblk is not implemented");
        }
    }
}
