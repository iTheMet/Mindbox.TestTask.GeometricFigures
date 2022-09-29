using ConsoleApp;
using GeometricFigures;

IFigure figure;

while (true)
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~\nChoose a figure:\n1 - Circle\n2 - Triangle\n");
    switch (Console.ReadLine())
    {
        case "1": figure = new Circle(1); break;

        case "2": figure = new Triangle(4, 10, 3); break;

        default : return;
    }
    Console.WriteLine($"\nArea of this {figure.GetType().Name} is {AreaCalculator.Calc(figure)}");
}


