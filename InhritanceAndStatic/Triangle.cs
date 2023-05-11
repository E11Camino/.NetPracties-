namespace InhritanceAndStatic
{
    internal class Triangle : IFigure
    {
        public string Name => "Triangle";
        public double[] Sides { get; set; }

        private Triangle()
        {
        }

        public Triangle(double side1, double side2, double side3)
        {
            Sides = new[] { side1, side2, side3 };
        }

        public double GetPerimeter()
        {
            return Math.Round(Sides.Sum(), 2);
        }

        public double GetSquare()
        {
            return Math.Round((Sides[0] * Sides[1]) / 2, 2);
        }
    }
}
