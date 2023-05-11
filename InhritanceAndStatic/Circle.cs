namespace InhritanceAndStatic
{
    internal class Circle : IFigure
    {
        public string Name => "Circle";
        public double[] Sides { get; set; }
        public double Radius { get; set; }

        private Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
            Sides = new double[] { Math.Round(2 * Math.PI * Radius, 2) };
        }

        public double GetPerimeter()
        {
            return Sides.First();
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * Radius * Radius);
        }
    }
}
