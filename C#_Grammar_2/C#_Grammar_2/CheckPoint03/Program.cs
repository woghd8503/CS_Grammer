using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * CheckPoint03 - 배열을 활용하기
-----------------------------------------------------------------------------*/
namespace CheckPoint03
{
    internal class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void Main(string[] args)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for(int j = 0; j < MAP_Y; j++)
                {
                    int titleIndex = _map[i, j];
                    Console.Write(_title[titleIndex]);

                    if(i == MAP_Y -1)
                        Console.WriteLine();
                }
            }
        }

        //static void C
    }
}
