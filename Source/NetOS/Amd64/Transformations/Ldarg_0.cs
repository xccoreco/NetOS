using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarg_0)]
        public static void Ldarg_0(Context context)
        {
            Ldarg(context);
        }
    }
}
