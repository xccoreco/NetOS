using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stloc_0)]
        public static void Stloc_0(Context context)
        {
            Stloc(context);
        }
    }
}
