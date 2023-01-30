using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    internal class MyDataType
    {   
        public int Number { get; set; }
        public bool NumberSign { get; }
        public MyDataType(int number)
        { 
            if (number == 0)
            {
                throw new Exception("The number 0 is not permitted. It will not saved");
            }
            Number = number;
            NumberSign = number > 0;
        }
    }
}
