using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stloc_2)]
        public static void Stloc_2(Context context)
        {
            Stloc(context);
        }
    }
}
