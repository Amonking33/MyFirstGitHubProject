using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Calculator **");

            Console.Write("Operand 1: ");
            int op1 = int.Parse(Console.ReadLine());

            Console.Write("Operand 2: ");
            int op2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{op1} / {op2} = {op1/op2}");
            Console.WriteLine($"{op1} + {op2} = {op1 + op2}");
            Console.WriteLine($"{op1} - {op2} = {op1 - op2}");
            Console.WriteLine($"{op1} * {op2} = {op1 * op2}");
            
            Console.ReadKey();
        }
    }
}
