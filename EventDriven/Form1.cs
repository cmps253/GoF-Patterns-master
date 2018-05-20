using System.Drawing;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        Car car;
        static int i;
        public Form1()
        {
            InitializeComponent();
            car = new Car();
            Car.Crash c = Crashed;
            
            car.OnCrash += c;
        }

        private void Crashed()
        {
            MessageBox.Show("Crashed!!!");
            this.BackColor = Color.Red;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Test");
        }
        private void foobar(object sender, System.EventArgs e)
        {
            car.SpeedUp();
            this.Text = car.ToString();
        }
    }
}
