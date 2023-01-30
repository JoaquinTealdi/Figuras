using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5Figuras
{
    internal class GLBTriangle : GLBFigure
    {
        public int Base { get; }   
        public int Height { get; }
        public override string? FigureName { get; set; }
        public GLBTriangle(int @base, int altura)
        {
            FigureName = "Triangle";
            Base = @base;
            Height = altura;
        }

        protected override int CalculateSurface()
        {
            int area = (Base * Height) / 2;
            return area;
        }  
    }
}
