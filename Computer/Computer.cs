using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Computer
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public CPU CPU { get; set; }
        public List<Disk> Disks { get; set; } = new List<Disk>();

        Computer(string make, string model)
        {
            Make = make;
            Model = model;
        }

        internal static Computer CreateInstance(string make, string mode) => new Computer(make, mode);
        public override string ToString()
        {
            var sb = new StringBuilder($"{Make} {Model}\n");
            Disks.ForEach(d => sb.Append(d));
            sb.Append(CPU);
            return sb.ToString();
        }
    }
}
