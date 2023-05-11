using System.Collections;

namespace InhritanceAndStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 5, 6);
            Circle circle = new Circle(2.5);

            IFigure[] figures = new IFigure[] { triangle, circle };

            foreach (IFigure figure in figures)
            {
                Console.WriteLine($"The {figure.Name}'s perimiter is - {figure.GetPerimeter()}, square area is - {figure.GetSquare()}");
            }

            Console.ReadKey();
        }
    }
}