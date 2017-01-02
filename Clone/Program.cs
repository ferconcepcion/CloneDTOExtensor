using CloneExtensor;
using System;

namespace CloneExample
{
    /// <summary>
    /// Class to execute examples to clone and convert example DTO´s.
    /// 
    /// Author:
    /// Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Clone example

            Console.WriteLine("Clone example, press key!");
            Console.ReadKey();
            Console.WriteLine();

            A1 A1ToClone = new A1();
            A1 A1cloneResult;

            if (A1ToClone.TryClone<A1>(out A1cloneResult))
            {
                Console.WriteLine("Cloned result: ");
                Console.WriteLine(string.Format("AA: {0}", A1cloneResult.AA));
                Console.WriteLine(string.Format("AB: {0}", A1cloneResult.AB));
                Console.WriteLine(string.Format("AC: {0}", A1cloneResult.AC));
                Console.WriteLine(string.Format("AD: {0}", A1cloneResult.AD.ToLocalTime()));
            }
            else
            {
                Console.WriteLine("Clone process error!");
            }
            
            Console.WriteLine();

            #endregion

            #region Convert example

            Console.WriteLine("Convert example, press key!");
            Console.ReadKey();
            Console.WriteLine();

            A1 A1ToConvert = new A1();
            A2 A2convertResult;

            if (A1ToClone.TryConvert<A2, A1>(out A2convertResult))
            {
                Console.WriteLine("Convert result: ");
                Console.WriteLine(string.Format("AA (double from int): {0}", A2convertResult.AA));
                Console.WriteLine(string.Format("AB: {0}", A2convertResult.AB));
                Console.WriteLine(string.Format("AC: {0}", A2convertResult.AC));
                Console.WriteLine(string.Format("AD: {0}", A2convertResult.AD.ToLocalTime()));
                Console.WriteLine(string.Format("AA2 (not exist in origin): {0}", A2convertResult.AA2));
            }
            else
            {
                Console.WriteLine("Convert process error!");
            }


            Console.WriteLine("Press key to exit!");
            Console.ReadKey();
            Console.WriteLine();

            #endregion
        }
    }


    public class A1
    {
        public A1()
        {
            AA = 1;
            AB = 2.3;
            AC = "Example to clone or convert";
            AD = DateTime.Now;
        }
        public int AA { get; set; }
        public double AB { get; set; }
        public string AC { get; set; }
        public DateTime AD { get; set; }
    }

    public class A2
    {
        public double AA { get; set; }
        public double AB { get; set; }
        public string AC { get; set; }
        public DateTime AD { get; set; }
        public string AA2 { get; set; }
    }
}
