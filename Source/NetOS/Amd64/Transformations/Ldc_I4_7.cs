using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldc_I4_7)]
        public static void Ldc_I4_7(Context context)
        {
            Ldc_I4(context);
        }
    }
}
