﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_Property01
{
    class AA
    {
        private int num;

        public int NUM
        {
            get { return num; }
            set { num = value; } //set 부분을 구현하지 않으면 readonly와 같은 읽기 전용
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.NUM = 100;

            Console.WriteLine("aa.NUM: {0}", aa.NUM);
        }
    }
}
