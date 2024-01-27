using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction A = new Fraction();
        Console.WriteLine(A.GetFractionString());
        Console.WriteLine(A.GetDecimalValue());

        Fraction B = new Fraction(5);
        Console.WriteLine(B.GetFractionString());
        Console.WriteLine(B.GetDecimalValue());

        Fraction C = new Fraction(3, 4);
        Console.WriteLine(C.GetFractionString());
        Console.WriteLine(C.GetDecimalValue());

        Fraction D = new Fraction(1, 3);
        Console.WriteLine(D.GetFractionString());
        Console.WriteLine(D.GetDecimalValue());
    }
}