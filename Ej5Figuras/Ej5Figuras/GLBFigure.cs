using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5Figuras
{
    internal abstract class GLBFigure
    {
        public abstract string? FigureName { get; set; }
        protected abstract int CalculateSurface();

        /// <summary>
        /// show the name and surface of the figure
        /// </summary>
        /// <returns></returns>
        public string PrintMessage()
        {
            return "The surface of the figure " + this.FigureName + " is " + this.CalculateSurface();
        }
    }
}
