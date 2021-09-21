using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex___HW
{
   public  static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Q1****");
            Console.WriteLine(StartWithD("Dabi"));

            Console.WriteLine("Q2****");
            Console.WriteLine(Q2DFJ("Jabi"));

            Console.WriteLine("Q3****");
            Console.WriteLine(Q3("D123456_JJ"));

            Console.WriteLine("Q4****");
            Console.WriteLine(Q4("yyy"));

            Console.WriteLine("Q5****");
            Console.WriteLine(Q5("Fabi"));

            Console.WriteLine("Q6****");
            Console.WriteLine(Q6("ABC"));

            Console.WriteLine("Q7****");
            Console.WriteLine(Q7("Fabi ZAKAY"));

            Console.WriteLine("Q8****");
            Console.WriteLine(Q8("13.33"));

            Console.WriteLine("Q9****");
            Console.WriteLine(Q9("25.333"));

            Console.WriteLine("Q10****");
            Console.WriteLine(Q9("fabi@gmail.com"));
        }

        public static bool StartWithD(this string str)
        {
            var regex = new Regex(@"^[D].*");
            return regex.IsMatch(str);

        }
        public static bool Q2DFJ(this string str)
        {
            var regex = new Regex(@"^[DFJ].*");
            return regex.IsMatch(str);
        }

        public static bool Q3(this string str)
        {
            var regex = new Regex(@"^[DFJ]\d[0-9]{6}\d(_)\w[A-Z]{2}");
            return regex.IsMatch(str);
        }

        public static string Q4(this string str)
        {
            var regex = new Regex(@"\d(yyy)|(zzzz)");
            return regex.Replace(str, " ");
        }
        public static bool Q5(this string str)
        {
            var regex = new Regex(@"^[A-Z]");
            return regex.IsMatch(str);
        }

        public static bool Q6(this string str)
        {
            var regex = new Regex(@"\b(abc)|(ABC)");
            return regex.IsMatch(str);
        }

        public static bool Q7(this string str)
        {
            var regex = new Regex(@"\D{2,18} {2,}");
            return regex.IsMatch(str);

        }

        public static bool Q8(this string str)
        {
            var regex = new Regex(@"^[0-9]+(.)[0-9]+");
            return regex.IsMatch(str);

        }

        public static bool Q9(this string str)
        {
            var regex = new Regex(@"^[0-9]+(.)[0-9]{3}");
            return regex.IsMatch(str);

        }

        public static bool Q10(this string str)
        {
            var regex = new Regex(@"^\d{2,20}(@)(gmail|yahoo)(.)(com)");
            return regex.IsMatch(str);

        }


    }
}
