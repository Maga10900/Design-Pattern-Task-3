// See https://aka.ms/new-console-template for more information
using AdapterdesignPattern;

Console.WriteLine("Hello, World!");

List<IDevice> devices = new List<IDevice>();
foreach (var device in devices)
{
    device.Work();
}