using System;

namespace myarrayapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            exercise5();
        }
        static void exercise1 ()
        {
            int count;
            int [] myArr = new int [10] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

            for (count = 0; count < 10; count ++)
            {
                Console.WriteLine (myArr[count]);
            }       
        }
        static void exercise2 ()
        {
            int iArrSize;
            int [] myArr;
            //int [] myReverseArray;

           Console.WriteLine("Please enter the size of your array>>");
           iArrSize = Convert.ToInt32(Console.ReadLine());     

           Console.WriteLine ("The array size is >> " + iArrSize);
           myArr = new int [iArrSize];

            int count;
           for (count = 0; count < iArrSize; count ++)
           {
               Console.WriteLine("Enter number for array pos " + count);
               myArr[count] = Convert.ToInt32(Console.ReadLine());
            }
             
           for (count = 0; count < iArrSize; count ++)
            {
                Console.WriteLine();
                Console.Write (myArr[count]);
            }

           for (count = iArrSize-1; count >= 0; count--)    
            {
                Console.Write("\n\n");
                Console.Write(myArr[count]);
            }

        }
        static void exercise3 ()
        {
            /*3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor
            Test Data : 
            Input the number of elements to be stored in the array :3 
            Input 3 elements in the array : 
            element - 0 : 2 
            element - 1 : 5 
            element - 2 : 8 
            Expected Output : 
            Sum of all elements stored in the array is : 15  */
            int iArrSize;
            int [] myArr;


           Console.WriteLine("Please enter the size of your array>>");
           iArrSize = Convert.ToInt32(Console.ReadLine());     

           Console.WriteLine ("The array size is >> " + iArrSize);
           myArr = new int [iArrSize];

            int count;
           for (count = 0; count < iArrSize; count ++)
           {
               Console.WriteLine("Enter number for array pos " + count);
               myArr[count] = Convert.ToInt32(Console.ReadLine());
            }
             
           int sum = 0;

           for (count = 0; count < iArrSize; count ++)
            {
                Console.WriteLine();
                Console.Write (myArr[count]);
                sum = sum + myArr[count];
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("The sum is >>" + sum);
        }

        static void exercise4()
        {
            int count;
            int [] myArr = new int [10] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
            int [] mySecondArray = new int[10];

            mySecondArray = myArr;

            for (count = 0; count < 10; count ++)
            {
                Console.WriteLine ("My first array >>" + myArr[count]);
            } 
            for (count = 0; count < 10; count ++)
            {
                Console.WriteLine ("My second array >>" + mySecondArray[count]);
            } 
        }
        static void exercise5 ()
        {
            int iArrSize;
            int [] myArr;

           Console.WriteLine("Please enter the size of your array>>");
           iArrSize = Convert.ToInt32(Console.ReadLine());     

           Console.WriteLine ("The array size is >> " + iArrSize);
           
           if (iArrSize == 1)
           {
               Console.WriteLine("Only 1 item in array.");
               return;
           }
           myArr = new int [iArrSize];

            int count;
           for (count = 0; count < iArrSize; count ++)
           {
               Console.WriteLine("Enter number for array pos " + count);
               myArr[count] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine();
            //Console.Write (myArr[count]);
 
            int DuplicateCount = 0;
            int NumToCheck;
            int nextcount;
            for (count = 0; count < iArrSize; count ++)
            {
                Console.WriteLine("going in");
                NumToCheck = myArr[count];
                Console.WriteLine(NumToCheck);
                for (nextcount = count+1; count < iArrSize; count++)
                {
                    Console.WriteLine("going in 2");
                    Console.WriteLine(myArr[nextcount]);
                    if (NumToCheck == myArr[nextcount])
                    {
                        Console.WriteLine("got one");
                        DuplicateCount++;
                    }
                }
            }
            Console.WriteLine ("Total number of duplicates is >> " + DuplicateCount);
        }
    }
}
