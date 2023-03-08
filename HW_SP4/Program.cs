using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 35;
            Fibonacci(n);
            Console.ReadLine();

             ParameterizedThreadStart FibonacciAsync = null;
             Thread thread = new Thread(new ParameterizedThreadStart(FibonacciAsync));//поточный метод
             thread.Start(5);
        }
        public static int Fibonacci(int len)
        {
            Fibonacci_Temp(0, 1, 1, len);
            return len;
        }
        //public static int Fibonacci(int len)
        //{
        //    if (len <= 1)
        //        return len;
        //    return Fibonacci(len - 1) + Fibonacci(len - 2);
        //}

        private static void Fibonacci_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Temp(b, a + b, counter + 1, len);
            }
        }
        static  void FibonacciAsync(object obj) //поточный метод
        {
            obj = Fibonacci((int)obj);
            Console.WriteLine(((int)obj).ToString());
        }
    }

}