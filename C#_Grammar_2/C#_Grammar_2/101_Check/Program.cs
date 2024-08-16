using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_Check
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 ID를 입력하세요?  ");
            this.id = int.Parse(Console.ReadLine());
        }

        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요?  ");
            this.kor = int.Parse(Console.ReadLine());
        }

        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요?  ");
            this.math = int.Parse(Console.ReadLine());
        }

        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요?  ");
            this.eng = int.Parse(Console.ReadLine());
        }
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
