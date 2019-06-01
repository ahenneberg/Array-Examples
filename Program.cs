using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays represent a fixed number of variables (called elements) of a particular type
            // An array initialization expression allows you to declare and populate an array in a single step:
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < vowels.Length; i++)
                Console.Write(vowels[i]);           // Loop that prints aeiou.
            // Creating an array always preinitializes the elements with default values.
            // The default value for a type is the result of a bitwise zeroing of memory.
            int[] a = new int[1000];
            Console.Write(a[123]);  // 0
            Point[] b = new Point[1000];
            int x = b[500].X;       // 0
            // To avoid a NullReferenceException from creating an array from a class, we must explicitly instantiate 1,000 Points after instantiating the array:
            Point2[] c = new Point2[1000];
            for (int i = 0; i < c.Length; i++)  // Iterates 0 to 999.
                c[i] = new Point2();            // Sets array element i to a new Point2.
            // ImportantNote0: An array itself is always a reference type object, regardless of the element type.
            // ImportantNote1: All array indexing is bounds-checked by the runtime. An IndexOutofRangeException is thrown if you use an invalide index.
        }
    }
    // Whether an array element type is a value type or a reference type has important performance implications. 
    // When the element type is a value type, each element value is allocated as part of the array. 
    // Had Point been a class, creating the array would have merely allocated 1,000 null references:
    public struct Point { public int X, Y; }
    public class Point2 { public int A, B; }
}
