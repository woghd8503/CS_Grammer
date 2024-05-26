﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _089_interface
 * DESC: interface 기본
-----------------------------------------------------------------------------*/

namespace _089_interface
{
    interface IAA
    {
        //public int a; //에러
        //private void IPrint() { } //에러..
        //public void IPrint(); //에러..
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("===========================================");
        }
    }

    class AA : IAA 
    {
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
    }

    

}

