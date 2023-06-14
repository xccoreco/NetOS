using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Brfalse_S)]
        public static void Brfalse_S(Context context)
        {
            Brfalse(context);
        }
    }
}
