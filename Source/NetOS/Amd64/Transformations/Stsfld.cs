using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stsfld)]
        public static void Stsfld(Context context)
        {
            context.Pop($"rax");
            context.StackOperationCount -= 1;
            context.Append($"mov [{Utility.SafeFieldName(((FieldDef)context.operand).DeclaringType, (FieldDef)context.operand)}],rax");
        }
    }
}
