namespace Computer
{
    public class Disk
    {
        public int Size { get; set; }
        public enum DiskType
        {
            SSD,
            Disk
        }
        public DiskType TypeOfDisk { get; set; }

        public Disk(int size, DiskType typeOfDisk)
        {
            Size = size;
            TypeOfDisk = typeOfDisk;
        }

        public override string ToString()
        {
            return $"{Size} GB, {TypeOfDisk}";
        }
    }
}
