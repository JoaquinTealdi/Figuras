using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Ej5Figuras
{
    internal class GLBCircle : GLBFigure
    {
        public override string? FigureName { get; set; }
        public int Radio { get; } 
        public GLBCircle(int radio)
        {
            FigureName = "Circle";
            Radio = radio;
        }
        
        protected override int CalculateSurface()
        {
            double surface = Radio * Radio * Math.PI;
            return (int) surface;
        }
    }
}
