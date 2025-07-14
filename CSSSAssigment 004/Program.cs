namespace cssassigment_04
{
    // 1. class    -> function
    // 2. struct    -> function
    // 3. interfaces    ->function
    // 4. Enum


    internal class Program
    {

        void printshape()
        {

            //body


        }
        //Entry point

        static void Main(string[] args)
        {
            Console.WriteLine(" v01 ");

            // int[] Number;
            // Declare for Reference (pointer) from type ' Array of Integers'
            // Numbers : Can Refer to obect from type ' Array of Integers  '
            // Numbers : Refer To Null

            // 8 Bytes Willl Be Allocted At Stack for the Reference 'Numbers'
            // 0 Bytes Will Be Allocated At Heep

            //Number = new int[size]


            //   Number = new int[5];


            //new
            // 1. Allocate the number required bytes for the obect at Heap ( 4 Bytes * 5  )
            // 2 . Initialize the allocated bytes with the default value of the datatypes
            // 3. call user_Defind constructor if exist
            // 4 . Assign the object to the reference 'numbers'

            //  Console.WriteLine(Number[0]);

            // Number[0] = 12;
            // Number[1] = 6;
            // Number[2] = 7;
            // Number[3] = 11;
            // Number[4] = 19;

            //Number[5] = 20 ;   //out of range

            // Console.WriteLine(Number[0]);
            // Console.WriteLine(Number[1]);
            // Console.WriteLine(Number[2]);
            // Console.WriteLine(Number[3]);
            // Console.WriteLine(Number[4]);

            // int[] number01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            // int[] number02 = new int [ 4 ] { 1,2,3,4};
            // int[] number03 = new int[6] { 1, 2, 3, 4 ,0,0 };
            // int[] number04 = new int[60];
            //

            //console.write(value : "Enter Numbers[0] : ");
            // Number[0] = int.parse(console.readline());


            //console.write(value : "Enter Numbers[1] : ");
            // Number[0] = int.parse(console.readline());

            //console.write(value : "Enter Numbers[2] : ");
            // Number[0] = int.parse(console.readline());

            //console.write(value : "Enter Numbers[3] : ");
            // Number[0] = int.parse(console.readline());

            //console.write(value : "Enter Numbers[4] : ");
            // Number[0] = int.parse(console.readline());

            // for (int i = 0; i < Numbers.length; i++)
            //{
            //    Console.WriteLine(value: "Enter numbers[{ i }] : ");
            //    Numbers[i] = int.Parse(Console.readline());
            //}

            //  Console.WriteLine("====================");

            // for (int i = 0; i < Numbers.length; i++)
            //{

            //    console.writline($" {Numbers[i] }");


            //}

            //one D array

            //Console.wrtline(Numbers.length);  //size
            //Console.WriteLine(Numbers.rank);  // Dimension


            Console.WriteLine("V02");

            //Two Do Array

            //int [ , ] marks = new int[3,3];

            //marks[0,0] = 99 ;
            //marks[0, 1] = 99;
            //marks[0, 2] = 99;


            //marks[1, 0] = 80;
            //marks[1, 1] = 98;
            //marks[1, 2] = 97;

            //marks[2, 0] = 88;
            //marks[2, 1] = 78;
            //marks[2, 2] = 47;

            //Console.WriteLine( marks[0,0]);
            //Console.WriteLine( marks[0, 1]);
            //Console.WriteLine(marks[0, 2] );

            //Console.WriteLine(marks[1, 0] );
            //Console.WriteLine(marks[1, 1] );
            //Console.WriteLine(marks[1, 2]);

            //Console.WriteLine(marks[2, 0]);
            //Console.WriteLine(marks[2, 1]);
            //Console.WriteLine(marks[2, 2]);

            //for( int i=0 ; i<3 ; i++ )
            //{
            //    for(int j=0 ; j<3 ; j++)
            //    {

            //       console.write($"Enter marks[{i},{j}] : ")
            //        marks[i,j]= int.parse(console.readline());
            //
            //    }
            // for(int i = 0 ; i<3;i++)
            // {
            //   console.write($"{marks[i,j]}")
            // }
            //}

            Console.WriteLine("V03");

            // int[][] marks = new int[3][];

            // marks [0] = new int[] { 1, 2, 3 };
            // marks[1] = new int[] { 1, 2};
            // marks[1] = new int[] { 1, 2, 3,4 };

            //int[][] marks = new int[2][];

            //marks[0] = new int[2];
            //marks[1] = new int[5];
            //marks[2] = new int[1];

            //for(int i=0; i<3; i++)
            //{

            //    for (int j = 0; j < marks[i].Length; j++)
            //   {
            //       marks[i][j] = int.Parse(Console.ReadLine());

            //   }

            // }



            //for (int i = 0; i < 3; i++)
            //{

            //   for (int j = 0; j < marks[i].Length; j++)
            //  {
            //      Console.WriteLine($" {marks[i][j]}");

            //   }

            //}


            //}  

            Console.WriteLine("V04");

            //functions : Block of code that have name if u need to execute this code
            // u need to call the function by the name
            //DRY

            // function prototype
            //1. signature
            //1.1  Name
            //1.2 Return type
            //1.3 parameters (inputs)

            //2. Body (code)


            // calling for the functions
            // printshape();

            //Methods
            //1. class memeber method  (static method)
            //2. object memeber method  ( non static method )


            Console.WriteLine("V05");

            // sumnumbers(10, 20);

            Console.WriteLine("V06");
            // passing by value
            // passing by reference

            // passing parameter value types
            // 1. passing by value
            // 2 passing

            //ex

            Console.WriteLine("V07");

            //passing parameter reference type
            //1. passing by value

            // int[] number ={ 1,2,3};
            // int result = sumarray(numbers);
            //console.writline(result);
            //console.writline(numbers[0]);

            //2. passing by reference
            // int[] number ={ 1,2,3};
            // int result = sumarray(numbers);
            //console.writline(result);
            //console.writline(numbers[0]);

            Console.WriteLine("V08");





        }

    }
}