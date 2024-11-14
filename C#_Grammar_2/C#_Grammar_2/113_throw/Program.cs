using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: _113_throw
 * DESC: throw 기초
 * 조건 연산자에서 사용된다.
-----------------------------------------------------------------------------*/
namespace _113_throw
{
    class Program
    {
        static void ThrowFunc(int data)
        {
            if(data > 0)
            {
                Console.WriteLine("ThrowFunc data: " + data);
            }
            else
            {
                throw new Exception("data에 0이 입력되었습니다.");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
