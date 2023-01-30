using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Numbers
    {
        List<int> RandomsNumbers = new List<int>();

        /// <summary>
        /// Generate 1000 random numbers between -100 and 100
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            Random random = new Random(); 
            for (int i = 0; i < 1000; i++)
            {
                RandomsNumbers.Add(random.Next(-100, 101));
            }
            return "numbers saved successfully";
        }

        /// <summary>
        /// Find the amount of positive numbers
        /// </summary>
        /// <returns></returns>
        public int PositiveNumbers()
        {
            var positive = (from d in RandomsNumbers
                             where d > 0
                             select d).Count();

            return positive;
        }

        /// <summary>
        /// Find the amount of zeroes 
        /// </summary>
        /// <returns></returns>
        public int ZeroNumbers()
        {
            var zero = (from d in RandomsNumbers
                        where d == 0
                        select d).Count();

            return zero;
        }

        /// <summary>
        /// Find the sum of negative numbers 
        /// </summary>
        /// <returns></returns>
        public int NegativeSum()
        {
            var negative = (from d in RandomsNumbers
                            where d < 0
                            select d).Sum();

            return negative;
        }

        /// <summary>
        /// Search the most common number and show how many times it appears
        /// </summary>
        /// <returns></returns>
        public int Repeated()
        {
            var groups = RandomsNumbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();

            return largest.Key;
        }
    }
}
