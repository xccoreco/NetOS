using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Dup)]
        public static void Dup(Context context)
        {
            //dangerous
            context.Append($"mov rax,[rsp]");
            context.Push($"rax");
            context.StackOperationCount++;
        }
    }
}
