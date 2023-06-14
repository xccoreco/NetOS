using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldsfld)]
        public static void Ldsfld(Context context)
        {
            //context.Push($"qword [{def.DeclaringType.SafeTypeName() + "_" + ((FieldDef)ins.Operand).Name}]");
            context.Append($"mov qword rax,[{Utility.SafeFieldName(((FieldDef)context.operand).DeclaringType, (FieldDef)context.operand)}]");
            context.Push($"rax");
            context.StackOperationCount += 1;
        }
    }
}
