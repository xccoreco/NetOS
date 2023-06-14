using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_U8)]
        public static void Conv_U8(Context context)
        {
            Conv_I8(context);
        }
    }
}
