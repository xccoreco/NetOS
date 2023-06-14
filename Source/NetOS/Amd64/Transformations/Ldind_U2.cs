using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldind_U2)]
        public static void Ldind_U2(Context context)
        {
            Ldind_I2(context);
        }
    }
}
