namespace MyApp
{
    public class Car
    {
        public delegate void Crash();
        public event Crash OnCrash;

        int speed;
        public void SpeedUp()
        {
            speed++;
            if (speed > 2)
            {
                OnCrash();
            }
        }
        public void SlowDown()
        {
            speed--;
        }

        public override string ToString()
        {
            return speed.ToString();
        }
    }
}
