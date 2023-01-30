using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    internal class Numbers
    {
        List<MyDataType> RandomNumbers = new List<MyDataType>();
        Random random = new Random();

        /// <summary>
        /// Generate 1000 random numbers between -100 and 100 without 0
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    RandomNumbers.Add(new MyDataType(random.Next(-100, 101)));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }      
            }
            return "numbers saved successfully";
        }

        /// <summary>
        /// Find the amount of positive numbers
        /// </summary>
        /// <returns></returns>
        public int PositiveNumbers()
        {
            var positive = (from d in RandomNumbers
                                   where d.NumberSign == true
                                   select d).Count();

            return positive;
        }

        /// <summary>
        /// Find the amount of zeroes 
        /// </summary>
        /// <returns></returns>
        public int ZeroNumbers()
        {
            var zero = (from d in RandomNumbers
                        where d.Number == 0
                        select d.Number).Count();

            return zero;
        }

        /// <summary>
        /// Find the amount of negative numbers 
        /// </summary>
        /// <returns></returns> 
        public int NegativeSum()
        {
            var negative = (from d in RandomNumbers
                            where d.Number < 0
                            select d.Number).Sum();

            return negative;
        }

        /// <summary>
        /// Search the most common number and show how many times it appears
        /// </summary>
        /// <returns></returns>
        public int Repeated()
        {
            var groups = RandomNumbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();

            return largest.Key.Number;
        }
    }
}
