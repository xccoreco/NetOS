﻿namespace System.Platform.Amd64
{
    public static class PIC
    {
        public static void Enable()
        {
            Native.Out8(0x20, 0x11);
            Native.Out8(0xA0, 0x11);
            Native.Out8(0x21, 0x20);
            Native.Out8(0xA1, 40);
            Native.Out8(0x21, 0x04);
            Native.Out8(0xA1, 0x02);
            Native.Out8(0x21, 0x01);
            Native.Out8(0xA1, 0x01);
            Native.Out8(0x21, 0x0);
            Native.Out8(0xA1, 0x0);
        }

        public static void EndOfInterrupt(ulong irq)
        {
            if (irq >= 40)
                Native.Out8(0xA0, 0x20);

            Native.Out8(0x20, 0x20);
        }

        public static void ClearMask(byte irq)
        {
            ushort port;
            byte value;

            if (irq < 8)
            {
                port = 0x21;
            }
            else
            {
                port = 0xA1;
                irq -= 8;
            }
            value = (byte)(Native.In8(port) & ~(1 << irq));
            Native.Out8(port, value);
        }
    }
}
