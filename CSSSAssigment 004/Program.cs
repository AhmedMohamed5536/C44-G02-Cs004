
// 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example

/*
Console.WriteLine("Q01");

namespace CSSSAssigment_004
{
    internal class Program
    {
        
        static void ByValue(int x)
        {
            x = 100;
        }

        
        static void ByReference(ref int x)
        {
            x = 100;
        }

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 5;

            
            ByValue(num1);
            ByReference(ref num2);

            
            Console.WriteLine(" ByValue: " + num1);       
            Console.WriteLine(" ByReference: " + num2);   
        }
    }
}



// 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

Console.WriteLine("V02");

namespace CSSSAssigment_004
{
    class Myclass
    {
        public int value = 10;
    }

    internal class Program
    {
        static void Byvalue(Myclass obj)
        {
            obj.value = 50; 
            obj = new Myclass(); 
            obj.value = 100;
        }

        static void ByReference(ref Myclass obj)
        {
            obj = new Myclass(); 
            obj.value = 200;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Q02");

            Myclass obj1 = new Myclass();
            Myclass obj2 = new Myclass();

            Byvalue(obj1);
            Console.WriteLine("By Value : " + obj1.value);      

            ByReference(ref obj2);
            Console.WriteLine("By Reference : " + obj2.value);  
        }
    }
}
*/

// 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

using System;

class Program
{
    static void SumAndSubtract(int a, int b, int c, int d, out int sum, out int subtract)
    {
        sum = a + b + c + d;
        subtract = a - b - c - d;
    }

    static void Main()
    {
        Console.WriteLine("V03");

        Console.WriteLine("Enter 4 numbers:");

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());

        SumAndSubtract(n1, n2, n3, n4, out int resultSum, out int resultSubtract);

        Console.WriteLine("Sum = " + resultSum);
        Console.WriteLine("Subtraction = " + resultSubtract);
    }
}





