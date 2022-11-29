using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Ui_Class;

namespace WpfApp1
{
    public class LadderPosition
    {
        //public int Positionx = 0;
        //public int Positiony = 0;
        public void PositionDown()
        {
            Console.WriteLine("□↓□");
        }
        public void PositionRight()
        {
            Console.WriteLine("□→□");
        }
        public void PositionLeft()
        {
            Console.WriteLine("□←□");
        }
    }
    public class Ui_Class
    {
        public class Random
        {

        }
        public class StartBox
        {
            public int StartB = 0;
            public int inputBoxNum = 0; // 입력된 박스 개수
            public int StartInBox = 0; // 처음에 담길 박스 개수
            public bool whileTrue = true; // 무조건 true를 하여 실행시킴
        }

        public class EndBox
        {
            public int EndB = 0;
            public int EndInBox = 0; // 마지막에 담길 박스 개수
        }
    }

    public class StartWhile
    {
        public static void Main(string[] argsr)
        {
            StartBox StartMain = new StartBox();
            EndBox EndMain = new EndBox();

            while (StartMain.whileTrue) // 바로 활성화
            {
                Console.WriteLine("몇 개를 입력 하시겠습니까?");
                StartMain.inputBoxNum = int.Parse(Console.ReadLine()); // inputBoxNum 안에 횟수를 입력
                StartMain.StartB = StartMain.inputBoxNum; // StartB 변수 안에 횟수를 할당
                Console.WriteLine("입력 받은 시작 박스 의 개수는 " + StartMain.StartB + " 개 입니다.\n");

                switch (StartMain.StartB) // 입력 된 횟수를 케이스로 찾아감
                {
                    case 5:
                        StartMain.StartInBox = StartMain.StartB; // 처음 들어갈 박스 박스안에 할당
                        EndMain.EndInBox = StartMain.StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 5개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartMain.StartInBox + "개 입니다. \n");
                        StartMain.whileTrue = false; // 강제종료 break; 가 안먹힘 이유는 모름
                        break;
                    case 4:
                        StartMain.StartInBox = StartMain.StartB;
                        EndMain.EndInBox = StartMain.StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 4개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartMain.StartInBox + "개 입니다. \n");
                        StartMain.whileTrue = false;
                        break;
                    case 3:
                        StartMain.StartInBox = StartMain.StartB;
                        EndMain.EndInBox = StartMain.StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 3개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartMain.StartInBox + "개 입니다. \n");
                        StartMain.whileTrue = false;
                        break;
                    case 2:
                        StartMain.StartInBox = StartMain.StartB;
                        EndMain.EndInBox = StartMain.StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 2개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartMain.StartInBox + "개 입니다.\n ");
                        StartMain.whileTrue = false;
                        break;
                    default:
                        Console.WriteLine("2개 이상 선택 해 주세요.\n");
                        Console.WriteLine("다시 입력해주세요. ^^ ( 최대 5개 )\n");
                        StartMain.whileTrue = false;
                        break;
                }
                LadderPosition LP = new LadderPosition(); // 사다리를 불러올 생성자 Ex ) : LP.PositionDown(); Result = > Console.WriteLine("↓");
                // Console.WriteLine("사다리에서 내려올 내용을 " + StartInBox + "개 적어주세요.\n");
                string[] StartArr = new string[StartMain.StartInBox]; // StartArr 배열 안에 입력할 횟수인 StartInBox
                Console.WriteLine("시작 박스 입력 가능한 횟수는 :" + StartArr.Length + "회 입니다. \n");
                for (int i = 0; i < StartArr.Length; i++)
                {
                    StartArr[i] = Console.ReadLine();
                }
                string[] EndArr = new string[EndMain.EndInBox]; // EndArr 배열 안에 입력할 횟수인 EndInBox

                Console.WriteLine("도착 박스 입력 가능한 횟수는 :" + EndArr.Length + "회 입니다.\n");

                for (int i = 0; i < EndArr.Length; i++)
                {
                    EndArr[i] = Console.ReadLine();
                }
                StartWhile StartMain2 = new StartWhile();
                while (StartMain.StartB >= 2) //StartB 가 2보다 많으면 실행 
                {
                    Console.WriteLine("1 ) Yes \n2 ) No");
                    string Guess = Console.ReadLine();
                    int forStartNum = 0; //가
                    int forEndNum = 0; //다                   
                    switch (int.Parse(Guess))
                    {
                        case 1:
                            Console.WriteLine("실행 되었습니다.\n");
                            for (int TryNumBox = 1; TryNumBox <= EndMain.EndInBox; TryNumBox++)
                            {
                                Console.WriteLine("□" + TryNumBox + "번 결과 입니다.□");
                                Console.WriteLine("□" + StartArr[forStartNum] + "□□□□□□□□"); // 가 - 나
                                forStartNum++;
                                LP.PositionDown();
                                //LP.PositionRight();
                                //LP.PositionDown();
                                Console.WriteLine("□" + EndArr[forEndNum] + "□□□□□□□□");  // 다 - 라 
                                forEndNum++;
                                // 출력 예상 결과 가 ↓  다
                                // 출력 예상 결과 나 ↓  라
                            }
                            StartMain.StartB = 1;
                            break;
                        case 2:
                            Console.WriteLine("취소 되었습니다.");
                            StartMain.StartB = 1;
                            break;
                    }
                }
            }
        }
    }
}