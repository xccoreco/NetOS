using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Mul_Ovf_Un)]
        public static void Mul_Ovf_Un(Context context)
        {
            //TO-DO Overflow Exception
            context.Append($"xor rdx,rdx");
            context.Pop($"rbx");
            context.Pop($"rax");
            context.StackOperationCount -= 2;
            context.Append($"mul rbx");
            context.Push($"rax");
            context.StackOperationCount += 1;
        }
    }
}
