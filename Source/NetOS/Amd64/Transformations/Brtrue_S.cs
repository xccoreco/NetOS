using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Brtrue_S)]
        public static void Brtrue_S(Context context)
        {
            Brtrue(context);
        }
    }
}
