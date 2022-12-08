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

        public int rowWrap = 0; // 전체적으로 큰 사다리 영역임. x - 1 
        public int rowLine = 3; //상수로 무조건 가로 사다리의 줄은 3줄로 설정
        public int rowRanNum = 50;  // 랜덤 Max 값 50 + 5                           
                
        public List<List<int>> allSet; 
        Random r = new Random(); // 랜덤 클래스 호출 

        internal void Init() 
        {
            allSet = new List<List<int>>();
            for(int i = 0; i < rowWrap; i++)
            {
                List<int> newLine = new List<int>();
                for(int j = 0; j < rowLine; j++)
                {
                    newLine.Add(r.Next(rowRanNum) + 5);
                }
                allSet.Add(newLine);
            }
        }
    }

    public class DataToken
    {
        
        public int PositionX,PositionY;

        ArrayList LadderIndex = new ArrayList();
        
        


        // LadderIndex.Add("x");


    }
}
