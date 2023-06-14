using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Switch)]
        public static void Switch(Context context)
        {
            throw new NotImplementedException("Switch is not implemented");
        }
    }
}
