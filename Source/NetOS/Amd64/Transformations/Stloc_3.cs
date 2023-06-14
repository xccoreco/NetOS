using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stloc_3)]
        public static void Stloc_3(Context context)
        {
            Stloc(context);
        }
    }
}
