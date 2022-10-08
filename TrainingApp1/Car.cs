using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp1
{
    internal class Car
    {
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        public Car(string pet)
        {
            petName = pet;
        }

        public Car(string pet, int speed)
        {
            petName = pet;
            currSpeed = speed;
        }

        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} kms/h");

        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
