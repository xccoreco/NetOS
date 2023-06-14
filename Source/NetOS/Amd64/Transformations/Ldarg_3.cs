using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarg_3)]
        public static void Ldarg_3(Context context)
        {
            Ldarg(context);
        }
    }
}
