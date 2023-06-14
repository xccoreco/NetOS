using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Cgt_Un)]
        public static void Cgt_Un(Context context)
        {
            Cgt(context);
        }
    }
}
