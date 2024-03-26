﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _073_Array_Func2
 * DESC: 함수 파라미터로 배열 처리(CallbyReference)
-----------------------------------------------------------------------------*/

namespace _072_Array_Func2
{
    class Program
    {
        static int[] CreateIntArray(int size)
        {
            int[] creArray = new int[size];

            for (int i = 0; i < creArray.Length; i++)
            {
                creArray[i] = 0;
            }

            return creArray;
        }

        static string[] CreateStrArray(int size)
        {
            string[] creArray = new string[size];

            for (int i = 0; i < creArray.Length; i++)
            {
                creArray[i] = string.Empty;
            }

            return creArray;
        }

        static int[,] CreateStrArray()
        {
            int[,] array = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    array[i, j] = 0;
                }
            }
            
            return array;
        }

        static void Main(string[] args)
        {
            int[] arrNum = CreateIntArray(3);
            string[] strName = CreateStrArray(5);
            int[,] array = CreateStrArray();
            
            foreach(int temp in arrNum)
            {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine("\n--------------------------");

            arrNum[0] = 1000;
            foreach(int temp in arrNum)
            {
                Console.WriteLine("  {0}", temp);
            }

            Console.WriteLine("\n--------------------------");

            foreach(string s in strName)
            {
                Console.WriteLine("strName: {0}", s);
            }

            Console.WriteLine("\n--------------------------");

            strName[0] = "Hello World";
            strName[1] = "!!!";

            foreach(string s in strName)
            {
                Console.WriteLine("strName: {0}", s);
            }

            Console.WriteLine("\n--------------------------");

            foreach(int data in array)
            {
                Console.WriteLine("data: {0}", data);
            }

            array[0, 0] = 10;
            array[2, 0] = 10;

            Console.WriteLine("--------------------------");

            foreach(int data in array)
            {
                Console.WriteLine("data: {0}", data);
            }
        }
    }
}