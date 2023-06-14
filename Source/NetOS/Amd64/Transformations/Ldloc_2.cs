using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldloc_2)]
        public static void Ldloc_2(Context context)
        {
            Ldloc(context);
        }
    }
}
