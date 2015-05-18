using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            Console.Out.WriteLine(s + "" == "");
            //var str = s.ToString();
            //Console.Out.WriteLine(s.ToString() == "");


            string s1 = "a";
            int k = 0;
            try
            {
                k = int.Parse(s1);
            }
            catch (Exception)
            {
                
                //throw;
            }

            var select = new[] {1, 2};

            var c = new ClassString();
            c.Select = select;

            Console.Out.WriteLine(k);
            Console.In.ReadLine();
        }
    }

    public class ClassString
    {
        public int[] Select { get; set; }
    }
}
