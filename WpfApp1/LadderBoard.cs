using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LadderBoard
    {

    }

    public class RowLadder
    {

        public int rowWrap = 0; // 전체적으로 큰 사다리 영역임. x - 1 / ex : 사다리 컬럼이 2개면 사다리 영역은 1개
        public int rowLine = 3; //상수로 무조건 가로 사다리의 줄은 3줄로 설정
                                      // 문제는 3개를 다 똑같이 일직선으로 놓을 것인지가 문제
                                      // 이런 문제 때문애 List를 사용하라고 했던 것 같음.



        public List<int> rowNum = new List<int>(); // 정수형으로 List 생성



    }

    public class ColumnLD
    {

    }
    public class DataToken
    {

    }
}
