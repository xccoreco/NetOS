using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Br)]
        public static void Br(Context context)
        {
            context.Append($"jmp {Utility.BrLabelName(context.ins, context.def)}");
        }
    }
}
