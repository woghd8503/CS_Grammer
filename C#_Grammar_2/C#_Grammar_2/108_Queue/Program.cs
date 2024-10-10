using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _108_Queue
 * DESC: Queue<T> 기초
-----------------------------------------------------------------------------*/
namespace _108_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueAA = new Queue<int>();
            queueAA.Enqueue(1);
            queueAA.Enqueue(2);

            for(int i = 0; i < 10; i++)
            {
                queueAA.Enqueue(i);
            }
        }
    }
}
