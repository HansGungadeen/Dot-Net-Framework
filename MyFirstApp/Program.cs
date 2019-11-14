using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////input and output
            //Console.WriteLine("Hello!");
            //Console.ReadLine();


            ////maths operation
            //int num1, num2, num3;
            //Console.WriteLine("Enter Num1:");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Num1: " + num1);
            //Console.WriteLine("Enter Num2:");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Num2: " + num2);
            //num3 = num1 + num2;
            //Console.WriteLine("Sum of {0} and {1} is {2}",num1,num2,num3);


            ////type casting
            //int a = 5;
            //int b = 2;
            //Console.WriteLine((double)a/b);
            //Console.ReadLine();


            ////if else implementation
            //Console.WriteLine("Enter Value of A");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Value of B");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Is A Greater than B?");
            //if (a>b)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");


            ////nested if else
            //int a = 74;
            //int b = 13;
            //int c = 632;
            //int d = 785;

            //if (a < b && a > c && a>d)
            //{
            //    Console.WriteLine("A is greater");
            //}
            //else
            //{
            //    if (b>a && b>c && b>d)
            //    {
            //        Console.WriteLine("B is greater");
            //    }
            //    else
            //    {
            //        if (c > a && c > d && c > b)
            //        {
            //            Console.WriteLine("C is greater");
            //        }
            //        else
            //        {
            //            Console.WriteLine("D is greater");
            //        }
            //    }
            //}


            ////switch case
            //int a = 45;
            //int b = 34;
            //Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
            //int choice = int.Parse(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine(a + b);
            //        break;
            //    case 2:
            //        Console.WriteLine(a - b);
            //        break;
            //    case 3:
            //        Console.WriteLine(a * b);
            //        break;
            //    case 4:
            //        Console.WriteLine((double)a / b);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input");
            //        break;
            //}


            //for loop

            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine("ha");
            //}

            //for (int i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////for even
            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i%2 == 0)
            //        Console.WriteLine(i);
            //}
            ////for odd
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //int n = 6;
            //for (int i = 1; i <= 10; i++) 
            //{
            //    //Console.WriteLine("{0} * {1} = {2)", n, i, (n * i));
            //}


            ////While loop
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Ha");
            //    i++;
            //}

            //Console.WriteLine("Enter value");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int r;
            //while (n !=0)
            //{
            //    r = n % 10;
            //    sum = sum + r;
            //    n = n / 10;
            //}
            //Console.WriteLine("Sum is:"+sum);


            ////Do while
            //int n;
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //}
            //while (n != 0);
            //Console.WriteLine("You have entered " + n);


            ////array
            //int[] A;
            //A = new int[10];

            //A[0] = 67;
            //A[1] = A[2] = A[3] = 56;
            //A[4] = A[1] + A[2] + A[3];
            //A[5] = A[6] = A[7] = A[4] - 10;
            //A[8] = A[9] = 50;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}


            ////array and foreach
            //int[] A = new int[5];
            //Console.WriteLine("Enter 5 Element");
            //for (int i = 0; i < 5; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("elements that you entered are:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}
            //Array.Sort(A);
            //Array.Reverse(A);
            //Console.WriteLine("Sorted Elements:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //int sum = 0;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    sum = sum + A[i];
            //}
            //Console.WriteLine("Sum is:" + sum);

            //foreach (var k in A)
            //{
            //    if (k % 2 == 0)
            //        Console.WriteLine(k);
            //}



            Console.ReadLine();

        }
    }
}
