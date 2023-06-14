using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Clt_Un)]
        public static void Clt_Un(Context context)
        {
            Clt(context);
        }
    }
}
