using DotLiquid.Tags;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{


    public class RowLadder
    {

        public int ListWrap = 0; // 전체적으로 큰 사다리 영역임. x - 1 
        public int rowLine = 3; //상수로 무조건 가로 사다리의 줄은 3줄로 설정
        public int rowRanNum = 50;  // 랜덤 Max 값 50 + 5
                                    // 
        static void main()
        {
                        
        }



        public List<List<int>> allSet;
        //public List<List<BorderInfo>> allSet;

        Random r = new Random(); // 랜덤 클래스 호출 

        internal void Init()
        {
            //allSet = new List<List<BorderInfo>>();
            allSet = new List<List<int>>();
            for (int i = 0; i < ListWrap; i++)
            {
                List<int> newLine = new List<int>();
                //List<BorderInfo> newLine = new List<BorderInfo>();
                for (int j = 0; j < rowLine; j++)
                {
                    BorderInfo borderInfo = new BorderInfo()
                    {
                        Height = r.Next(rowRanNum) + 5,
                        Link1 = new LinkInfo(0, 1),

                    };
                    newLine.Add(r.Next(rowRanNum) + 5);
                    //newLine.Add(borderInfo);
                }
                allSet.Add(newLine);
            }
        }

        class BorderInfo
        {
            double height;
            LinkInfo Link;

            public double Height { get => height; set => height = value; }
            public LinkInfo Link1 { get => Link; set => Link = value; }
        }
        class LinkInfo
        {
            int startIndex;
            int endIndex;


            public LinkInfo(int v1, int v2)
            {
                this.StartIndex = v1;
                this.EndIndex = v2;
            }

            public int StartIndex { get => startIndex; set => startIndex = value; }
            public int EndIndex { get => endIndex; set => endIndex = value; }
        }
    }

    public class DataToken
    {


        public int PositionX, PositionY;

        List<int> LadderIndex = new List<int>();


        // 시작 버튼을 눌렀을 때, 
        // 유저의 수를 입력 받은 만큼
        // ~를 만들어준다. 1.배열 안에 무엇이 있고 무엇을 식별을 하고 행동할 것인가?
        // 어떠한 방법으로 사다리를 인식하고 내려갈 것인가?
        // 우선 연결되는 사다리는 무엇으로 생성하는지. 랜덤 난수로 55중에 3개를 출력한다.



    }
}
