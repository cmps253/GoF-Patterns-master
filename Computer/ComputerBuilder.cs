using System;
using System.Collections.Generic;
using System.Text;
using static Computer.Disk;

namespace Computer
{
    //this class has a single responsiblity, that of creating an instance of a computer (in a complete state, cpu, disk, ram, screen,...)
    public class ComputerBuilder
    {
        private Computer computer;
        private ComputerBuilder(string make, string model)
        {
            computer = Computer.CreateInstance(make, model);
        }
        
        public static ComputerBuilder CreateInstance(string make, string model) => new ComputerBuilder(make, model);

        public ComputerBuilder AddDisk(Disk disk)
        {
            if(computer.Disks.Count==2)
            {
                throw new MaxOfTwoDisksExceededException("No more than two disks can be added!");
            }
            computer.Disks.Add(disk);
            return this;
        }

        //programming pleasantness
        /// <summary>
        /// Adds a disk to the computer being built
        /// </summary>
        /// <param name="size">Size of the disk in GB</param>
        /// <param name="typeOfDisk">Type of the disk (SSD or Disk)</param>
        /// <returns></returns>
        public ComputerBuilder AddDisk(int size, DiskType typeOfDisk) => AddDisk(new Disk(size, typeOfDisk));
        
        public ComputerBuilder AddCPU(CPU cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public Computer Build() => computer;

        [Serializable]
        public class MaxOfTwoDisksExceededException : Exception
        {
            public MaxOfTwoDisksExceededException() { }
            public MaxOfTwoDisksExceededException(string message) : base(message) { }
            public MaxOfTwoDisksExceededException(string message, Exception inner) : base(message, inner) { }
            protected MaxOfTwoDisksExceededException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
