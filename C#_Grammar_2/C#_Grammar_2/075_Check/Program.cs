using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요?  ");
            ID[index] = int.Parse(Console.ReadLine());
        }

        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요?  ");
            kor[index] = int.Parse(Console.ReadLine());
        }

        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요?  ");
            math[index] = int.Parse(Console.ReadLine());
        }

        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요?  ");
            eng[index] = int.Parse(Console.ReadLine());
        }

        static int checkID(int id, int max, int[] ID)
        {
            for(int i = 0; i < max; i++)
            {
                if (ID[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            const int MAX = 3;

            int[] arrID = new int[MAX];
            int[] arrKor = new int[MAX];
            int[] arrMath = new int[MAX];
            int[] arrEng = new int[MAX];

            int inputSel = 0;
            int selID = -1;

            for(int i = 0; i < MAX; i++)
            {
                InputID(arrID, i);
                InputID(arrKor, i);
                InputID(arrMath, i);
                InputID(arrEng, i);

                Console.WriteLine();
            }

            Console.Clear();

            while(true)
            {

            }

        }
    }
}