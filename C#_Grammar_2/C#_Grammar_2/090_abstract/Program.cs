using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _090_abstract
 * DESC: abstract 기본
-----------------------------------------------------------------------------*/
namespace _090_abstract
{
    abstract class abstractAA
    {
        public int num;

        public abstract void abstractPrin(); //강제적으로 상속받은 클래스에서 구현부를 정의..
        
        public virtual void virtualPrint()
        {

        }

        public void Print()
        {

        }

    }
    
    class AA : abstractAA
    {
        public override void abstractPrin()
        {
            Console.WriteLine("abstractPrint");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("override void virtualPrint()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.abstractPrin();
            aa.virtualPrint();
        }
    }
}
