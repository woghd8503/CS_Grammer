using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094_Check
{
    class CSaveNumber
    {
        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber()
        {
            number1 = 0;
            number2 = 0;
        }

        public void InputNumber(int count)
        {
            if(count == 0)
            {
                Console.Write("첫번째 수를 입력 해 주세요?");
                number1 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("두번째 수를 입력 해주세요?");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
