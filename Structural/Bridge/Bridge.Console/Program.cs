using Bridge.DesignPattern.Abstraction;
using Bridge.DesignPattern.Implementation;

IHardware newHardware = new NewHardware();
IHardware oldHardware = new OldHardware();

ISystem linuxOnNewHardware = new LinuxSystem(newHardware);
linuxOnNewHardware.Start();
linuxOnNewHardware.ExecuteCommand("create new file");
linuxOnNewHardware.ExecuteCommand("save file");
linuxOnNewHardware.Shutdown();
Console.WriteLine();

ISystem linuxOnOldHardware = new LinuxSystem(oldHardware);
linuxOnOldHardware.Start();
linuxOnOldHardware.ExecuteCommand("create new file");
linuxOnOldHardware.ExecuteCommand("save file");
linuxOnOldHardware.Shutdown();