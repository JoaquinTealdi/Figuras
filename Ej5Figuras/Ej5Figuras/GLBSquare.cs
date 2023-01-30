using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5Figuras
{
    internal class GLBSquare : GLBFigure
    {
        public override string? FigureName { get; set; }
        public int Base { get; }
        public GLBSquare(int @base)
        {
            FigureName = "Square";
            Base = @base;   
        }

        protected override int CalculateSurface()
        {
            return Base * Base;
        }
    }
}
