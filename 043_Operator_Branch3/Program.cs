﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name : _043_Operator_Branch3
 * DESC : 조건문에 &&, || 연산자를 이용하기 기초
-----------------------------------------------------------------------------*/
namespace _043_Operator_Branch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if(isA && isB) //false && true => false
            {
                Console.WriteLine("false && true => false");
            }

            if(isB || isD) //true || false => true
            {
                Console.WriteLine("true && true => true");
            }

            if(isC || isD) //true || false => true
            {
                Console.WriteLine("true || false => true");
            }

            if (2 > 1 && 3 < 4 || 1 > 2)
            {
                Console.WriteLine("true && false || false => true");
            }
        }
    }
}
