using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint05
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;
        private int total;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }
        public int TOTAL { get { return total; } }

        public CStudent(int id, int kor, int math, int eng)
        {
            this.id = id;
            this.kor = kor;
            this.math = math;
            this.eng = eng;

            this.total = kor + math + eng;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<CStudent> listData = new List<CStudent>();
            bool IsLoop = true;

            InitData(listData);

            do
            {
                Console.WriteLine("메뉴를 골라주세요?");
                Console.Write("(1)id정령 (2)성적순 정렬 (3)국어 점수 정렬 ");
                string inputNum = Console.ReadLine();

                switch(inputNum)
                {
                    case "0":
                        Console.WriteLine("프로그램 종료");
                        IsLoop = false;
                        break;

                    case "1":
                        //SortID(listData);
                        break;

                    case "2":
                        //SortTotal(listData);
                        break;
                    case "3":
                        //SortKor(listData);
                        break;
                    case "4":
                        //FindDataUp(listData, true);
                        break;
                    case "5":
                        //FindDataup(listData, false);

                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하시요~~~~");
                        break;
                }
            }
            while (IsLoop);
        }

        /// <summary>
        /// 학생 데이터를 생성
        /// 0 0 0 0
        /// 1, ?, ?, ?
        /// </summary>
        /// <param name="_listData"></param>
        static void InitData(List<CStudent> _listData)
        {
            Random rd = new Random();

            for(int i = 0; i < 10; i++)
            {
                CStudent data = new CStudent(i, rd.Next(0, 100), rd.Next(0, 100), rd.Next(0, 100));
                _listData.Add(data);
            }
        }

        static void PrintList(List<CStudent> _listData)
        {

        }
    }
}
