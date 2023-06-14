using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldind_U1)]
        public static void Ldind_U1(Context context)
        {
            Ldind_I1(context);
        }
    }
}
