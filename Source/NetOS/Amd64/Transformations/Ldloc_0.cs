using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldloc_0)]
        public static void Ldloc_0(Context context)
        {
            Ldloc(context);
        }
    }
}
