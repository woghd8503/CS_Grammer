﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name : _ 045_Operator_switch
 * DESC : switch기초
-----------------------------------------------------------------------------*/
namespace _044_Operator_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string strGrade = null;

            Console.WriteLine("점수를 입력하세요: ");
            num = int.Parse(Console.ReadLine());

            switch(num / 10)
            {
                case 10:
                case 9:
                    strGrade = "A";
                    break;

                case 8:
                    strGrade = "B";
                    break;

                case 7:
                    strGrade = "C";
                    break;

                case 6:
                    strGrade = "D";
                    break;

                default:
                    strGrade = "F";
                    break;
            }

            Console.WriteLine("결과값은= {0}", strGrade);
        }
    }
}
