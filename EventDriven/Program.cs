using System;

namespace CMPS253.AdvancedTopics.EventDrivenProgramming
{
    static class Program
    {
        static void Main()
        {
            Car car;
            car = new Car();
            car.OnCrash += Crashed;
            car.SpeedUp();
            car.SpeedUp();
            car.SpeedUp();
        }

        static void Crashed()
        {
            Console.WriteLine("Crashed!!!");
        }
    }
}
