using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FirstDemoNewBatch 
{
    public delegate void Mydel();
    public class Student
    {
        public event Mydel Fail;
        public event Mydel Distinction;
        public void AcceptMarks(int marks)
        {
            if (marks < 40)
            {
                Fail(); // call to the event or raise an event
            }
            else if (marks >= 75)
            {
                Distinction();
            }
            Console.WriteLine($"Your Score is {marks}");
        }
    }
    class Program
    {
       static void FailMsg()
        {
            Console.WriteLine("You are fail !");
        }
        static void DistinctionMsg()
        {
            Console.WriteLine("Congratulations ! You are pass with Distinction");
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //event and delegate binding
            s1.Fail += new Mydel(FailMsg);
            s1.Distinction += new Mydel(DistinctionMsg);
            s1.AcceptMarks(64);

        }
       
    }
    
}







////bubble sort example
//int[] arr = new int[5] { 5,3,8,4,6 };
//int num = 5, temp;
//for (int x = 0; x < num - 1; x++)
//{
//    for (int y = 0; y < num - x - 1; y++)
//    {
//        if (arr[y] > arr[y + 1])
//        {
//            temp = arr[y];
//            arr[y] = arr[y + 1];
//            arr[y + 1] = temp;
//        }
//    }
//}
//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine(arr[i]);
//}


// Selection sort example
//int[] arr = { 29, 72, 98, 13, 87 };
//Console.WriteLine("Before Selection Sort\n");
//foreach (int item in arr)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//for (int i = 0; i < arr.Length - 1; i++)
//{
//    int index = i;
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[j] < arr[index])
//        {
//            index = j;//searching for lowest index  
//        }
//    }
//    int smallerNumber = arr[index];
//    arr[index] = arr[i];
//    arr[i] = smallerNumber;
//}

//Console.WriteLine("\nAfter Selection Sort\n");
//foreach (int item in arr)
//{
//    Console.Write($"{item} ");
//}


