using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class InputBox
    {

        StartBox Start = new StartBox();
        EndBox EndBox = new EndBox();
    }

    // string[] StartInputArr = new string[] { };
    // 배열 할 필요가 없음 TextBox 자체에서 자료가 남아있기에 저장해두면 된다.
    // 혹여나 사다리타기 게임이 데이터 토큰까지 완성 후 마지막 페이지에
    // 사용자들을 위해 한 눈에 보기 쉽게 만들려한다면 Start , End 박스 안에 있는
    // 내용들을 배열 안에 담고 출력해주는 것도 괜찮은 방법이다.

    public class StartBox
    {
        public int SetBoxMAX = 5;
        public int SetBoxMIN = 2;
    }
    public class EndBox
    {
        public int SetBoxMAX = 5;
        public int SetBoxMIN = 2;
    }
}
