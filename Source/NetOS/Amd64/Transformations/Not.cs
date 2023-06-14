using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Not)]
        public static void Not(Context context)
        {
            context.Pop($"rax");
            context.StackOperationCount -= 1;
            context.Append($"not rax");
            context.Push($"rax");
            context.StackOperationCount += 1;
        }
    }
}
