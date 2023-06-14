using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_I2)]
        public static void Conv_I2(Context context)
        {
            context.Append($"xor rdx,rdx");
            context.Append($"mov rbx,0xFFFF");
            context.Pop($"rax");
            context.StackOperationCount -= 1;
            context.Append($"and rax,rbx");
            context.Push($"rax");
            context.StackOperationCount += 1; 
        }
    }
}
