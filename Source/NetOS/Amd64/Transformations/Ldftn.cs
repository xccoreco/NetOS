using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldftn)]
        public static void Ldftn(Context context)
        {
            if((context.operand is MethodDef)) 
            {
                context.Append($"mov qword rax,{Utility.SafeMethodName((MethodDef)context.operand, ((MethodDef)context.operand).MethodSig)}");
                context.Push($"rax");
                context.StackOperationCount += 1;
            }
            else
            {
                throw new NotImplementedException("Ldftn is not implemented");
            }
        }
    }
}
