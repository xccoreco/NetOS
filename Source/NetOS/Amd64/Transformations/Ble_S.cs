using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ble_S)]
        public static void Ble_S(Context context)
        {
            Ble(context);
        }
    }
}
