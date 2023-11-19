using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: _052_Operator_continue
 * DESC: continue 기초
-----------------------------------------------------------------------------*/
namespace _052_Operator_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("i: " + i);
            }
        }
    }
}
