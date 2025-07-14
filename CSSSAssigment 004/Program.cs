
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

*/

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


