using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _118_delegateParam
 * DESC: delegate 파라미터
-----------------------------------------------------------------------------*/
namespace _118_delegateParam
{
    delegate void delegateFunc();

    class MessageProcess
    {
        delegateFunc CallOkFunc;
        delegateFunc CallCancelFunc;

        static void Main(string[] args)
        {
        }
    }
}
