﻿using NetOS.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace NetOS
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Br_S)]
        public static void Br_S(Context context)
        {
            Br(context);
        }
    }
}
