using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp1
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeeeeeee Haaaaaaaaaaaeewwww!");
            }
        }

        public Motorcycle(int driverIntensity)
        {
            this.driverIntensity = driverIntensity;
        }

        public Motorcycle()
        {
        }

        public void SetDriverName(string name) => this.name = name;
    }
}
