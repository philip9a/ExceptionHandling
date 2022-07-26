using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.Write("Exception has occured ;");
        }
    }
    internal class Program
    { 
        public double DivisionOperation(double numerator,double denominator)
        {
            if (denominator == 0)
                throw new DivByZero();
            return numerator / denominator; 
        }
        static void Main(string[] args)
        {
            #region
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i <arr.Length; i++)
            //{
            //  Console.WriteLine(arr[i]);
            //}
            //try
            //{
            //   Console.WriteLine(arr[7]);
            //}
            //catch (Exception e)
            //{
            //    string s = $"{e.Message} {arr[1]}";
            //    Console.WriteLine("An Exception has occured ",e.Message, "faith");
            //}
            //finally
            //{

            //    Console.WriteLine("Finally block is executed");
            //}
            #endregion
            Program obj = new Program();
            double num = 9, den = 0, quotient;
            try
            {
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
