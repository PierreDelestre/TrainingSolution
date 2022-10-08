// See https://aka.ms/new-console-template for more information
using TrainingApp1;

var auto = new Car();

for (int i = 0; i < 10; i++)
{
    auto.SpeedUp(5);
    auto.PrintState();
}

Console.WriteLine();

var otherCar = new Car("Mary");
otherCar.PrintState();

var anotherCar = new Car("John", 120);
anotherCar.PrintState();

var moto = new Motorcycle(3);
moto.PopAWheely();

Console.WriteLine();

var m = new Motorcycle(5);
m.SetDriverName("Brandon");
m.PopAWheely();
Console.WriteLine($"Rider name is {m.name}");

Console.ReadKey();
