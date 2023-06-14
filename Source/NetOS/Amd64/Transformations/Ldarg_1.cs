using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarg_1)]
        public static void Ldarg_1(Context context)
        {
            Ldarg(context);
        }
    }
}
