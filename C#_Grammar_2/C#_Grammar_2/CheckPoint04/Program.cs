using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: CheckPoint04
 * DESC: Control1, Manager클래스 제작하여 시스템 만들기..
-----------------------------------------------------------------------------*/
namespace CheckPoint04
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;
        public virtual void Run()
        {
            Console.Write("{0}의 속도로 ", _Speed);
        }

        public virtual void Attack()
        {
            Console.WriteLine();

            if(this is Healer)
            {
                Console.Write("[마법 공격력 - {0}]으로 ", _Attack * _MP);
            }
            else
            {
                Console.Write("[공격력 - {0}]으로 ", _Attack);
            }
        }
    }

    class Barbarian : Army
    {
        public Barbarian() 
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;
        }

        public override void Run() 
        {
            base.Run();

            Console.WriteLine("Barbarian 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Barbarian이 칼로 공격!!! ");
        }
    }

    class Giant : Army 
    {
        public Giant() 
        {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;
        }

        public override void Run() 
        {
            base.Run();

            Console.WriteLine("Giant 달려갑니다. ");
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Giant 공격 !!! ");
        }
    }

    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("Healer 날아갑니다. ", _Speed);
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("Healer 마법 공격!!! ");
        }
    }

    class UnitControl
    {
        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER,
        }

        const int MAX = 10;
        Army[] _ArrArmys;
        int indexCount;

        public UnitControl() 
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
