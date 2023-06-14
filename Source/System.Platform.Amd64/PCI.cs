﻿namespace System.Platform.Amd64
{
    public class PCIDevice
    {
        public ushort Bus;
        public ushort Slot;
        public ushort Function;
        public ushort VendorID;

        public ushort DeviceID;

        public byte ClassID;
        public byte SubClassID;
        public byte IRQ;

        public uint Bar0;
        public uint Bar1;
        public uint Bar2;
        public uint Bar3;
        public uint Bar4;
        public uint Bar5;

        public void WriteRegister(ushort Register,ushort Value) 
        {
            PCI.WriteRegister16(Bus, Slot, Function, (byte)Register, (ushort)(ReadRegister(Register) | Value));
        }

        public ushort ReadRegister(ushort Register)
        {
            return PCI.ReadRegister16(Bus, Slot, Function, (byte)Register);
        }
    }

    public static unsafe class PCI
    {
        public static PCIDevice[] Devices = new PCIDevice[32];
        public static int index = 0;

        public static PCIDevice GetDevice(ushort VendorID,ushort DeviceID) 
        {
            for(ulong i = 0; i < Devices.Length; i++) 
            {
                if (
                    Devices[i] != null &&
                    Devices[i].VendorID == VendorID &&
                    Devices[i].DeviceID == DeviceID
                    ) 
                {
                    return Devices[i];
                }
            }
            return null;
        }

        static PCI()
        {
            if (GetHeaderType(0, 0, 0) == 0)
            {
                CheckBus(0);

                for (int i = 0; i < index; i++)
                {
                    Console.Write("PCI Device:");
                    Console.Write("Bus:");
                    Console.Write(((ulong)Devices[i].Bus).ToString());
                    Console.Write(" ");
                    Console.Write("Slot:");
                    Console.Write(((ulong)Devices[i].Slot).ToString());
                    Console.Write(" ");
                    Console.Write("Func:");
                    Console.Write(((ulong)Devices[i].Function).ToString());
                    Console.Write(" ");
                    Console.Write("Bar0:0x");
                    Console.Write(((ulong)Devices[i].Bar0).ToString("x2"));
                    Console.Write(" ");
                    Console.Write("VendorID:0x");
                    Console.Write(((ulong)Devices[i].VendorID).ToString("x2"));
                    Console.WriteLine();
                }
            }
        }

        private static void CheckBus(ushort Bus)
        {
            for (ushort slot = 0; slot < 32; slot++)
            {
                ushort vendorID = GetVendorID(Bus, slot, 0);
                if (vendorID == 0xFFFF)
                {
                    continue;
                }

                PCIDevice device = new PCIDevice();
                device.Bus = Bus;
                device.Slot = slot;
                device.Function = 0;
                device.VendorID = vendorID;

                device.Bar0 = ReadRegister(device.Bus, device.Slot, device.Function, 0x10);
                device.Bar1 = ReadRegister(device.Bus, device.Slot, device.Function, 0x14);
                device.Bar2 = ReadRegister(device.Bus, device.Slot, device.Function, 0x18);
                device.Bar3 = ReadRegister(device.Bus, device.Slot, device.Function, 0x1C);
                device.Bar4 = ReadRegister(device.Bus, device.Slot, device.Function, 0x20);
                device.Bar5 = ReadRegister(device.Bus, device.Slot, device.Function, 0x24);

                device.ClassID = ReadRegister8(device.Bus, device.Slot, device.Function, 11);
                device.SubClassID = ReadRegister8(device.Bus, device.Slot, device.Function, 10);
                device.IRQ = (byte)(0x20 + ReadRegister8(device.Bus, device.Slot, device.Function, 60));

                device.DeviceID = ReadRegister16(device.Bus, device.Slot, device.Function, 2);

                Devices[index] = device;
                index++;

                if(device.ClassID == 0x06 && device.SubClassID == 0x04) 
                {
                    Console.WriteLine("TODO - This is a sub-PCI Controller");
                }
                continue; //Must exist
            }
        }

        public static uint ReadRegister(ushort Bus, ushort Slot, ushort Function, byte aRegister)
        {
            uint xAddr = PCI.GetAddressBase(Bus, Slot, Function) | ((uint)(aRegister & 0xFC));
            Native.Out32(0xCF8, xAddr);
            return Native.In32(0xCFC);
        }

        public static ushort ReadRegister16(ushort Bus, ushort Slot, ushort Function, byte aRegister)
        {
            uint xAddr = PCI.GetAddressBase(Bus, Slot, Function) | ((uint)(aRegister & 0xFC));
            Native.Out32(0xCF8, xAddr);
            return (UInt16)(Native.In32(0xCFC) >> ((aRegister % 4) * 8) & 0xFFFF);
        }

        public static byte ReadRegister8(ushort Bus, ushort Slot, ushort Function, byte aRegister)
        {
            uint xAddr = PCI.GetAddressBase(Bus, Slot, Function) | ((uint)(aRegister & 0xFC));
            Native.Out32(0xCF8, xAddr);
            return ((byte)(Native.In32(0xCFC) >> ((aRegister % 4) * 8) & 0xFF));
        }

        public static void WriteRegister16(ushort Bus, ushort Slot, ushort Function, byte aRegister, ushort Value)
        {
            uint xAddr = GetAddressBase(Bus, Slot, Function) | ((uint)(aRegister & 0xFC));
            Native.Out32(0xCF8, xAddr);
            Native.Out16(0xCFC, Value);
        }

        public static ushort GetVendorID(ushort Bus, ushort Slot, ushort Function)
        {
            uint xAddr = GetAddressBase(Bus, Slot, Function) | 0x0 & 0xFC;
            Native.Out32(0xCF8, xAddr);
            return (ushort)(Native.In32(0xCFC) >> ((0x0 % 4) * 8) & 0xFFFF);
        }

        public static ushort GetHeaderType(ushort Bus, ushort Slot, ushort Function)
        {
            uint xAddr = GetAddressBase(Bus, Slot, Function) | 0xE & 0xFC;
            Native.Out32(0xCF8, xAddr);
            return (byte)(Native.In32(0xCFC) >> ((0xE % 4) * 8) & 0xFF);
        }

        public static uint GetAddressBase(ushort Bus, uint Slot, uint Function)
        {
            return (uint)(0x80000000 | (Bus << 16) | ((Slot & 0x1F) << 11) | ((Function & 0x07) << 8));
        }
    }
}
