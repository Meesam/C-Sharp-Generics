using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Generics");
        int a = 10, b = 20;
        Console.WriteLine($"a {a}  b {b}");
        Swap<int>(ref a, ref b );
        Console.WriteLine($"a {a}  b {b}");

        string c = "Hello", d = "World";
        Console.WriteLine($"c {c}  d {d}");
        Swap<string>(ref c, ref d);
        Console.WriteLine($"c {c}  d {d}");
    }

    static void Swap<T>(ref T a, ref T b)
    { 
       T temp = a;
       a = b;
       b = temp;
    }
}
