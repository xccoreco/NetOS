using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Shr_Un)]
        public static void Shr_Un(Context context)
        {
            context.Append($"xor rdx,rdx");
            context.Pop($"rcx");
            context.Pop($"rax");
            context.StackOperationCount -= 2;
            context.Append($"shr rax,cl");
            context.Push($"rax");
            context.StackOperationCount += 1;
        }
    }
}
