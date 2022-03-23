using System;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer mycomputer = 
                ComputerBuilder
                    .CreateInstance("Lenovo", "Yoga 10")
                    .AddDisk(new Disk(255, Disk.DiskType.SSD))
                    .AddDisk(1000, Disk.DiskType.Disk)
                    .AddCPU(CPU.CreateInstance("Intel", "I9", 4.0F))
                    .Build();
            Console.WriteLine(mycomputer);
        }
    }
}
