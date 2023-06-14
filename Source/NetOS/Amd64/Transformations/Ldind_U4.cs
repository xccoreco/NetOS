using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldind_U4)]
        public static void Ldind_U4(Context context)
        {
            Ldind_I4(context);
        }
    }
}
