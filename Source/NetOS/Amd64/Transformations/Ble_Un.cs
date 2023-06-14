using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ble_Un)]
        public static void Ble_Un(Context context)
        {
            Ble(context);
        }
    }
}
