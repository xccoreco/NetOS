using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldc_I4)]
        public static void Ldc_I4(Context context)
        {
            context.Append($"mov rax,{OperandParser.Ldc(context.ins)}");
            context.Push($"rax");
            context.StackOperationCount += 1;
        }
    }
}
