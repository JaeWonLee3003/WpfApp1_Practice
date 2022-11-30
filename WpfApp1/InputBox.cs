using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class InputBox
    {
        public int SetBox = 2;
        StartBox Start = new StartBox();
        EndBox EndBox = new EndBox(); 
    }
    public class StartBox
    {
        // string[] StartInputArr = new string[] { };
        // 배열 할 필요가 없음 TextBox 자체에서 자료가 남아있기에 저장해두면 된다.
    }
    public class EndBox
    {

    }
}
