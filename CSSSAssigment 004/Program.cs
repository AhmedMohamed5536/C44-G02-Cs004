
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



// 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

using System;

class Program
{
    static int AddDigits(int num)
    {
        int total = 0;

        while (num > 0)
        {
            int digit = num % 10;   
            total = total + digit;  
            num = num / 10;         
        }

        return total;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = AddDigits(number);

        Console.WriteLine("The sum of the digits of the number " + number + " is: " + sum);
    }
}



// 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false; 
        }

        return true; 
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine(num + " is a prime number.");
        else
            Console.WriteLine(num + " is NOT a prime number.");
    }
}


// 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 8, 1, 9, 3 }; 

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; 
            }

            if (numbers[i] > max)
            {
                max = numbers[i]; 
            }
        }

        Console.WriteLine("Smallest number = " + min);
        Console.WriteLine("Largest number = " + max);
    }
}

// 7- Create function to calculate the factorial of the number specified as parameter

using System;

class Program
{
    
    static int Factorial(int num)
    {
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            result = result * i;
        }

        return result;
    }

    static void Main()
    {
        int number = 5;  

        int fact = Factorial(number);

        Console.WriteLine("Factorial of " + number + " is: " + fact);
    }
}
*/

// 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

using System;

class Program
{
    
    static string ChangeChar(string word, int position, char newChar)
    {
        char[] chars = word.ToCharArray(); 

        chars[position] = newChar;         
        return new string(chars);          
    }

    static void Main()
    {
        string text = "hello";     
        int pos = 1;              
        char replacement = 'a';    

        string result = ChangeChar(text, pos, replacement);

        Console.WriteLine("Before: " + text);
        Console.WriteLine("After:  " + result);
    }
}


