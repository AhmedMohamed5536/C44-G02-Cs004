
// 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example



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


/*
namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}





namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



namespace CSSSAssigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
*/
