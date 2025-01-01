﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _115_CustomException
 * DESC: CustomException 기초, when 키워드, StackTrace 키워드
-----------------------------------------------------------------------------*/
namespace _115_CustomException
{
    class MyException : ApplicationException
    {
        public int Num { get; set; }
        public MyException() : base()
        {

        }

        public override string ToString()
        {
            return "Num: " + Num;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
