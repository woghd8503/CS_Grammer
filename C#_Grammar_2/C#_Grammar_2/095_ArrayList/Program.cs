using System;
using System.Collections;

/*-----------------------------------------------------------------------------
 * Name: _095_ArrayList
 * DESC: ArrayList 기본
-----------------------------------------------------------------------------*/
namespace _095_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Hello");
            arrayList.Add(10f);

            for(int i = 0; i < 10; i++)
            {
                arrayList.Add(i);
            }

            foreach(object data in arrayList)
            {
                Console.WriteLine("arrList data: " + data);
            }

            //배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach(object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: " + data);
            }
        }
    }
}
