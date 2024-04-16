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

        }

    }
}