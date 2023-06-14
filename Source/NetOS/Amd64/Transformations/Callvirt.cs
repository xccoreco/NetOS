using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Callvirt)]
        public static void Callvirt(Context context)
        {
            Call(context);
        }
    }
}
