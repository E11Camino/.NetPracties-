using System;

namespace InhritanceAndStatic
{
    internal interface IFigure
    {
        public string Name { get; }
        public double[] Sides { get; }

        public double GetPerimeter();

        public double GetSquare();
    }
}
