using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello");
    //        int num1 = Convert.ToInt32(Console.ReadLine());
    //        double num2 = Convert.ToDouble(Console.ReadLine());

    //        double sum = num1 + num2;
    //        Console.WriteLine(sum);
    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num1, num2, temp;
    //        Console.Write("Input the First Number : ");
    //        num1 = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Input the Second Number : ");
    //        num2 = Convert.ToInt32(Console.ReadLine());

    //        // using three variables
    //        temp = num1;
    //        num1 = num2;
    //        num2 = temp;

    //        Console.WriteLine("\nAfter Swapping :");
    //        Console.WriteLine("\nFirst Number : " + num1);
    //        Console.WriteLine("\nSecond Number : " + num2);

    //        // using two variables
    //        Console.Write("\nInput the First Number : ");
    //        int x = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Input the Second Number : ");
    //        int y = Convert.ToInt32(Console.ReadLine());

    //        x = x + y;
    //        y = x - y;
    //        x = x - y;

    //        Console.WriteLine("\nAfter Swapping :");
    //        Console.WriteLine("\nFirst Number : " + x);
    //        Console.WriteLine("\nSecond Number : " + y);

    //        // another way using two variables
    //        Console.Write("\nInput the First Number : ");
    //        int p = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Input the Second Number : ");
    //        int q = Convert.ToInt32(Console.ReadLine());

    //        p = p * q;
    //        q = p / q;
    //        p = p / q;

    //        Console.WriteLine("\nAfter Swapping :");
    //        Console.WriteLine("\nFirst Number : " + p);
    //        Console.WriteLine("\nSecond Number : " + q);

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num, res;
    //        Console.Write("Enter the Number : ");
    //        num = Convert.ToInt32(Console.ReadLine());

    //        for (int i = 0; i <= 10; i++)
    //        {
    //            res = num * i;
    //            Console.WriteLine("{0} * {1} = {2}",num, i, res);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num1, num2, num3, num4;
    //        double res;
    //        Console.Write("Enter the First Number : ");
    //        num1 = Convert.ToInt32(Console.ReadLine());


    //        Console.Write("Enter the Second Number : ");
    //        num2 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter the Third Number : ");
    //        num3 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter the Fourth Number : ");
    //        num4 = Convert.ToInt32(Console.ReadLine());

    //        res = (num1 + num2 + num3 + num4)/4;

    //        Console.WriteLine("The average of {0},{1},{2},{3} is: {4}", num1,num2,num3,num4, res);

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double c, k, f;
    //        Console.Write("Enter the amount of celcius: ");
    //        c =Convert.ToInt32(Console.ReadLine());

    //        k = c + 273;
    //        f = (c*1.8)+32;

    //        Console.WriteLine("Expected Output:\nKelvin = " + k + "\nFarenheit = " + f);

    //        Console.ReadKey();
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            double c, k, f;
            Console.Write("Enter the amount of celcius: ");
            c = Convert.ToInt32(Console.ReadLine());

            k = c + 273;
            f = (c * 1.8) + 32;

            Console.WriteLine("Expected Output:\nKelvin = " + k + "\nFarenheit = " + f);

            Console.ReadKey();
        }
    }
}
