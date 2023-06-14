# Note
Original project link is stated after, NetOS plans to continue the operating system solution [CS2ASM](https://github.com/nifanfa/CS2ASM).

# NetOS
NetOS is a compiler which translates C# code into x86/x64 assembly.<br/>
By using this compiler, you may create your own operating system using any language that compiles to CIL.

## Usage
``NetOS -a<address> -c<amd64> -f<bin,elf> -t<none,iso> -o<output> <input>``

For example:

``./NetOS -a0x100000 -camd64 -felf -tiso -ooutput.iso ConsoleApp1.dll``

You can now try to run on bare metal, or via QEMU:

``qemu-system-x86_64 -cdrom output.iso -cpu max -m 1G -enable-kvm -serial stdio``

**You need to have LLVM on your PATH to execute the ELF linker, LLD!**

**Be sure to remove the ``-enable-kvm`` argument if you're not on Linux!**

## System.Private.Corlib
NetOS includes a (**very incomplete**) version of the .NET core library.

## System.Platform.Amd64
NetOS also includes a neat ``System.Platform.Amd64`` namespace where simple drivers reside.

## Playground.ConsoleApp1
For the sake of simplicity, an example operating system that uses the ``System.Platform.Amd64`` namespace has been included.

![Screenshot](Screenshots/QQ截图20211215002513.png)

## Notes
**NetOS is not IL2CPU!**<br/>
**Currently, only the AMD64 platform is supported.**
