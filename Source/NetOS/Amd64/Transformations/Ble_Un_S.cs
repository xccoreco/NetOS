using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ble_Un_S)]
        public static void Ble_Un_S(Context context)
        {
            Ble(context);
        }
    }
}
