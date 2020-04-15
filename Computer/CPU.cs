namespace Computer
{
    public class CPU
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public float Frequency { get; set; }
        CPU(string make, string model, float frequency)
        {
            Make = make;
            Model = model;
            Frequency = frequency;
        }

        public static CPU CreateInstance (string make, string model, float frequency) => new CPU(make, model, frequency);
    }
}
