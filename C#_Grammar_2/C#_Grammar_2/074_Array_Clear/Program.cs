﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _074_Array_Clear
 * DESC: 배열 관리 함수
-----------------------------------------------------------------------------*/
namespace _074_Array_Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            Array.Clear(array, 0, array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}  ", array[i]);
            }

            Console.WriteLine("\n-----------------------------");

            int[,] arrNum = new int[3, 2];

            Console.WriteLine("\n-------  Array.Clear  ------");
            Array.Clear(arrNum, 0, arrNum.Length);

            for(int i = 0; i < arrNum.GetLength(0); i++)
            {
                for(int j = 0; j < arrNum.GetLength(1); j++)
                {
                    arrNum[i, j] = (i * arrNum.GetLength(1)) + j;
                }
            }

            for(int i = 0; i < arrNum.GetLength(0); i++)
            {
                for(int j = 0; j < arrNum.GetLength(1); j++)
                {
                    Console.Write("  " + arrNum[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            int[,,] arrMULTI1 = new int[,,]
            {
                {{0, 1}, {2, 3}, {4, 5}},
                {{6, 7}, {8, 9}, {10, 11}},
                {{12, 13}, {8, 9}, {10, 11}},
                {{12, 13}, {14, 15}, {16, 17}},
                {{13, 14}, {14,15}, {16, 17}}
            };

            Console.WriteLine("arrMulti1.Length: " + arrMULTI1.Length);


        }
    }
}