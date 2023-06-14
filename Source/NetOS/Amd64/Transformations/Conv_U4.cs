using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_U4)]
        public static void Conv_U4(Context context)
        {
            Conv_I4(context);
        }
    }
}
