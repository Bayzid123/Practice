using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

    //// Remove Character

    //internal class Program
    //{
    //    public static string Remove_char(string str, int n)
    //    {
    //        return str.Remove(n, 1);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Remove_char("w3schools", 1));
    //        Console.WriteLine(Remove_char("w3schools", 8));
    //        Console.WriteLine(Remove_char("w3schools", 0));
    //        Console.WriteLine(Remove_char("w3schools", 3));

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    public static string First_Last(string str)
    //    {
    //        return str.Length > 1 ? str.Substring(str.Length -1) + 
    //            str.Substring(1, str.Length -2) + str.Substring(0,1) : str;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(First_Last("w3schools"));
    //        Console.WriteLine(First_Last("python"));
    //        Console.WriteLine(First_Last("x"));

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string line = "C# is widely used for developing desktop and web applications and also web services.";

    //        string[] words = line.Split(new[] {" "}, StringSplitOptions.None );

    //        string word = "";
    //        int ctr = 0;

    //        foreach (string str in words)
    //        {
    //            if (str.Length > ctr)
    //            {
    //                word = str;
    //                ctr = str.Length;
    //            }
    //        }

    //        Console.WriteLine(word);

    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Odd numbers from 1 to 100");
    //        for (int i = 1; i <= 100; i++)
    //        {
    //            if (i%2 != 0)
    //            {
    //                Console.WriteLine(i);
    //            }
    //        }

    //        Console.WriteLine("Even numbers from 1 to 100");
    //        for (int i = 1; i <= 100; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                Console.WriteLine(i);
    //            }
    //        }

    //        Console.ReadKey();
    //    }
    //}

    // palindrome number
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num, r, sum = 0, i;
    //        Console.Write("Input a positive integer: ");
    //        num = Convert.ToInt32(Console.ReadLine());

    //        for (i = num; num != 0; num = num / 10)
    //        {
    //            r = num % 10;
    //            sum = sum * 10 + r;
    //        }
    //        Console.WriteLine("Is {0} is a palindrome number?", i);
    //        if (i == sum)
    //        {
    //            Console.WriteLine("Yes");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No");
    //        }
    //        Console.ReadKey();
    //    }
    //}

    // palindrome string
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string s, revs = "";
    //        Console.WriteLine(" Enter string");
    //        s = Console.ReadLine();
    //        for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
    //        {
    //            revs += s[i].ToString();
    //        }
    //        if (revs == s) // Checking whether string is palindrome or not  
    //        {
    //            Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
    //        }
    //        else
    //        {
    //            Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    public static int Check_large(int x, int y, int z)
    //    {
    //        int max = Math.Max(x, Math.Max(y, z));
    //        return max;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Check_large(1,2,3));
    //        Console.ReadKey();
    //    }
    //}

    //internal class Program
    //{
    //    public static bool Is_prime(int n)
    //    {
    //        int x = (int)Math.Floor(Math.Sqrt(n));
    //        if (n == 1)
    //        {
    //            return false;
    //        }
    //        if (n==2)
    //        {
    //            return true;
    //        }
    //        for (int i = 2; i <= x; ++i)
    //        {
    //            if (n%i == 0)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Sum of the first 500 Prime Numbers: ");
    //        long sum = 0;
    //        int ctr = 0;
    //        int n = 2;
    //        while (ctr < 500)
    //        {
    //            if (Is_prime(n))
    //            {
    //                sum += n;
    //                ctr++;
    //            }
    //            n++;
    //        }
    //        Console.WriteLine(sum.ToString());
    //        Console.ReadKey();
    //    }
    //}

    // Absolute Difference of even and odd indexed elements in an Array

    //internal class Program
    //{
    //    public static void even_odd_diff(int[] arr, int n)
    //    {
    //        int even = 0;
    //        int odd = 0;

    //        for (int i = 0; i < n; i++)
    //        {
    //            if(i%2 == 0)
    //            {
    //                even = Math.Abs(even - arr[i]);
    //            }
    //            else
    //            {
    //                odd = Math.Abs(odd - arr[i]);
    //            }
    //        }

    //        Console.WriteLine("Even Index absolute " +
    //              "difference : " + even);
    //        Console.WriteLine("Odd Index absolute " +
    //                          "difference : " + odd);
    //    }
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3, 4, 5, 6 };
    //        int n = arr.Length;
    //        even_odd_diff(arr, n);

    //        Console.ReadKey();
    //    }
    //}

    // Summation of Array

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3, 4, 5, 6 };
    //        int res = arr.Sum();
    //        Console.WriteLine(res);

    //        Console.ReadKey();
    //    }
    //}

    // String alignment
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(166701);

    //        Console.WriteLine("{0, 10}", 1);

    //        Console.ReadKey();
    //    }
    //}

    // Make a one sorted array from two different sorted arrays without sort function.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array1 = new int[] { 3, 5, 6, 9, 12, 14, 18, 20, 25, 28 };
    //        int[] array2 = new int[] { 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };

    //        int count1 = array1.Length;
    //        int count2 = array2.Length;
    //        int[] arrayResult = new int[count1 + count2];

    //        int a = 0, b = 0;   // indexes in origin arrays
    //        int i = 0;          // index in result array

    //        // join
    //        while (a < count1 && b < count2)
    //        {
    //            if (array1[a] <= array2[b])
    //            {
    //                // element in first array at current index 'a'
    //                // is less or equals to element in second array at index 'b'
    //                arrayResult[i++] = array1[a++];
    //            }
    //            else
    //            {
    //                arrayResult[i++] = array2[b++];
    //            }
    //        }

    //        // tail
    //        if (a < count1)
    //        {
    //            // fill tail from first array
    //            for (int j = a; j < count1; j++)
    //            {
    //                arrayResult[i++] = array1[j];
    //            }
    //        }
    //        else
    //        {
    //            // fill tail from second array
    //            for (int j = b; j < count2; j++)
    //            {
    //                arrayResult[i++] = array2[j];
    //            }
    //        }

    //        // print result
    //        Console.WriteLine("Result is {{ {0} }}", string.Join(",", arrayResult.Select(e => e.ToString())));
    //        Console.ReadKey();
    //    }
    //}



    // Given a string s, the task is to encrypt the string in the following way: 

    //If the frequency of current character is even, then increment current character by x.
    //If the frequency of current character is odd, then decrement current character by x.


    //internal class Program
    //{
    //    static int MAX = 26;

    //    // Function to return the encrypted string
    //    public static char[] encryptStr(String str, int n, int x)
    //    {

    //        // Reduce x because rotation of
    //        // length 26 is unnecessary
    //        x = x % MAX;
    //        char[] arr = str.ToCharArray();

    //        // calculate the frequency of characters
    //        int[] freq = new int[MAX];
    //        for (int i = 0; i < n; i++)
    //            freq[arr[i] - 'a']++;

    //        for (int i = 0; i < n; i++)
    //        {

    //            // If the frequency of current character
    //            // is even then increment it by x
    //            if (freq[arr[i] - 'a'] % 2 == 0)
    //            {
    //                int pos = (arr[i] - 'a' + x) % MAX;
    //                arr[i] = (char)(pos + 'a');
    //            }

    //            // Else decrement it by x
    //            else
    //            {
    //                int pos = (arr[i] - 'a' - x);
    //                if (pos < 0)
    //                    pos += MAX;
    //                arr[i] = (char)(pos + 'a');
    //            }
    //        }

    //        // Return the count
    //        return arr;
    //    }

    //    // Driver code
    //    public static void Main(String[] args)
    //    {
    //        String s = "abcda";
    //        int n = s.Length;
    //        int x = 3;
    //        Console.WriteLine(encryptStr(s, n, x));

    //        Console.ReadKey();
    //    }
    //}

    // Given an array, cyclically rotate the array clockwise by one.
    //public class Test
    //{
    //    static int[] arr = new int[] { 1, 2, 3, 4, 5 };

    //    // Method for rotation
    //    static void rotate()
    //    {
    //        //int x = arr[arr.Length - 1], i;

    //        //for (i = arr.Length - 1; i > 0; i--)
    //        //    arr[i] = arr[i - 1];
    //        //arr[0] = x;



    //        int n = arr[arr.Length - 1];

    //        // i and j pointing to first and
    //        // last element respectively
    //        int i = 0, j = n - 1;
    //        while (i != j)
    //        {
    //            {
    //                int temp = arr[i];
    //                arr[i] = arr[j];
    //                arr[j] = temp;
    //            }
    //            i++;
    //        }
    //    }

    //    // Driver Code
    //    public static void Main()
    //    {
    //        Console.WriteLine("Given Array is");
    //        string Original_array = string.Join(" ", arr);
    //        Console.WriteLine(Original_array);

    //        rotate();

    //        Console.WriteLine("Rotated Array is");
    //        string Rotated_array = string.Join(" ", arr);
    //        Console.WriteLine(Rotated_array);

    //        Console.ReadKey();
    //    }
    //}

    // fibonacci
    //public class Test
    //{
    //    public static int Fib(int n)
    //    {
    //        if (n <= 1)
    //        {
    //            return n;
    //        }
    //        else
    //        {
    //            return Fib(n - 1) + Fib(n - 2);
    //        }
    //    }

    //    // driver code
    //    public static void Main(string[] args)
    //    {
    //        int n = 9;
    //        Console.Write(Fib(n));
    //        Console.ReadKey();
    //    }
    //}

    // Find out whether the string is an anagram or not.
    //public class Anagram
    //{

    //    static int NO_OF_CHARS = 256;

    //    /* function to check whether two strings
    //    are anagram of each other */
    //    static bool areAnagram(char[] str1, char[] str2)
    //    {
    //        // Create 2 count arrays and initialize
    //        // all values as 0
    //        int[] count1 = new int[NO_OF_CHARS];
    //        int[] count2 = new int[NO_OF_CHARS];
    //        int i;

    //        // For each character in input strings,
    //        // increment count in the corresponding
    //        // count array
    //        for (i = 0; i < str1.Length && i < str2.Length;
    //             i++)
    //        {
    //            count1[str1[i]]++;
    //            count2[str2[i]]++;
    //        }

    //        // If both strings are of different length.
    //        // Removing this condition will make the program
    //        // fail for strings like "aaca" and "aca"
    //        if (str1.Length != str2.Length)
    //            return false;

    //        // Compare count arrays
    //        for (i = 0; i < NO_OF_CHARS; i++)
    //            if (count1[i] != count2[i])
    //                return false;

    //        return true;
    //    }

    //    /* Driver code*/
    //    public static void Main()
    //    {
    //        //char[] str1 = ("gram").ToCharArray();
    //        //char[] str2 = ("arm").ToCharArray();
    //        char[] str1, str2;
    //        str1 =Console.ReadLine().ToCharArray();
    //        str2 =Console.ReadLine().ToCharArray();

    //        // Function Call
    //        if (areAnagram(str1, str2))
    //            Console.WriteLine("The two strings are"
    //                              + " anagram of each other");
    //        else
    //            Console.WriteLine("The two strings are not"
    //                              + " anagram of each other");
    //        Console.ReadKey();
    //    }
    //}


    // Repeating Element in an array
    //public class DuplicateElement
    //{
    //    public static void Main()
    //    {
    //        int[] arr = new int[] {1,2,3,4,2,7,8,8,3};
    //        Console.WriteLine("Duplicate elements in given array: ");

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            for (int j = i+1; j < arr.Length; j++)
    //            {
    //                if (arr[i] == arr[j])
    //                {
    //                    Console.WriteLine(arr[j]);
    //                }
    //            }
    //        }
    //        Console.ReadKey();
    //    }
    //}

    // Divide a long sentence into multiple sentences with length at most N so that no word is broken in multiple lines.
    class Program
    {
        static void Main(string[] args)
        {
            int x, cnt = 0; x = Convert.ToInt32(Console.ReadLine());
            string s = "", temp = "", word = ""; s = Console.ReadLine();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (cnt < x)
                {
                    if (s[i] != ' ')
                    {
                        word += s[i];
                        cnt++;
                    }
                    else
                    {
                        if (temp.Length == 0)
                        {
                            temp += word;
                            word = "";
                            cnt++;
                        }
                        else
                        {
                            if (temp.Length + word.Length + 1 < x)
                            {
                                temp += ' ' + word;
                                word = "";
                            }
                            else
                            {
                                Console.WriteLine(temp);
                                temp = word;
                                cnt = word.Length;
                                word = "";
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(temp);
                    temp = "";
                    //word = "";
                    i--;
                    cnt = 0;
                }
            }
            if (word.Length != 0)
            {
                if (temp.Length == 0)
                {
                    temp += word;
                    word = "";
                }
                else
                {
                    if (temp.Length + word.Length + 1 < x)
                    {
                        temp += ' ' + word;
                        word = "";
                    }
                    else
                    {
                        Console.WriteLine(temp);
                        temp = word;
                        cnt = word.Length;
                        word = "";
                    }
                }
            }
            if (temp.Length != 0) Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
