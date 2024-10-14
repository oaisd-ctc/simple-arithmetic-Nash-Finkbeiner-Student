using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide a whole number.");
        int add1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a whole number to add to " + add1 + ".");
        int add2 = int.Parse(Console.ReadLine());
        int adds = add1 + add2;
        Console.WriteLine("The Answer to the problem " + add1 + " + " + add2 + " is " + adds + ".");
        Console.WriteLine("Provide Two more whole numbers to subtract with.");
        int sub1 = int.Parse(Console.ReadLine());
        int sub2 = int.Parse(Console.ReadLine());
        int subs = sub1 - sub2;
        Console.WriteLine("The Answer to the the problem of " + sub1 + " - " + sub2 + " is " + subs + ".");
        Console.WriteLine("Provide Two more whole numbers to multiply together.");
        int mul1 = int.Parse(Console.ReadLine());
        int mul2 = int.Parse(Console.ReadLine());
        int muls = mul1 * mul2;
        Console.WriteLine("The Answer to the the problem of " + mul1 + " * " + mul2 + " is " + muls + ".");
        Console.WriteLine("Provide Two more whole numbers to divide with.");
        int div1 = int.Parse(Console.ReadLine());
        int div2 = int.Parse(Console.ReadLine());
        int divs = div1 / div2;
        Console.WriteLine("The Answer to the the problem of " + div1 + " / " + div2 + " is " + divs + ".");
        Console.WriteLine("Provide Two decimal numbers to divide with.");
        float decDiv1 = float.Parse(Console.ReadLine());
        float decDiv2 = float.Parse(Console.ReadLine());
        float decDivs = decDiv1 / decDiv2;
        Console.WriteLine("The Answer to the the problem of " + decDiv1 + " / " + decDiv2 + " is " + decDivs + ".");
        Console.WriteLine("Provide Two more whole numbers to divide and find the remainder of.");
        int rem1 = int.Parse(Console.ReadLine());
        int rem2 = int.Parse(Console.ReadLine());
        int rems = rem1 % rem2;
        Console.WriteLine("The Answer to the the problem of " + rem1 + " % " + rem2 + " is " + rems + ".");
        /* Finished */
    }
}