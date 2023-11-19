using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*-----------------------------------------------------------------------------
* Name: _048_Operator_for
* DESC: enum데이터 선언 후 switch문 사용하기
-----------------------------------------------------------------------------*/
namespace _048_Operator_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine("total:  " + total);
        }
    }
}
