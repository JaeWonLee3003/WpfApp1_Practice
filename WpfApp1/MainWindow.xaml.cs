using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Console;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

        }
        /// <summary>
        /// NumOutBox라는 TextBox 내용이 바뀌는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NumOutbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 시작 Text 박스의 갯수를 인지해주는 클래스 호출 
            StartBox startBox = new StartBox();
            // 도착 Text 박스의 갯수를 인지해주는 클래스 호출
            EndBox endBox = new EndBox();

            // 1. 텍스트가 바뀌면 -> 컬럼이 입력한 갯수만큼 늘어나거나 줄어든다.
            var temp = NumOutbox.Text;
            if (int.TryParse(temp, out int result)) // 입력한 내용이 숫자가 아니라면
            {
                if (result >= startBox.SetBoxMIN && result <= startBox.SetBoxMAX) // 예외처리 2 이상 5 이하
                {
                    // 2 이상 5 이하 라면 값을 result 할당됨
                }
                else
                {
                    NumOutbox.Text = "2";
                    System.Windows.MessageBox.Show("숫자를 입력해주세요 \nPlease enter a number \n( Tip : 2 ~ 5 )");
                }
            }
            else
            {
                // 문자 일 때 경고 창을 띄워준다.
                System.Windows.MessageBox.Show("숫자를 입력해주세요 \nPlease enter a number");
            }
        }
        /// <summary>
        /// 클릭을 하면 숫자가 1이 늘어나고 컬럼이 한개 추가됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetBtn_Click(object sender, RoutedEventArgs e)
        // 몇 개의 사다리로 실행할 것 인지 NumOutBox 안에 있는 수를 반영하여 사다리를 만든다. 
        {
            GenerateAll(); // 모두 생성한다는 이름을 가진 메서드
        }
        private void GenerateAll()
        {
            int colCount; // 사다리 컬럼의 수

            if (!int.TryParse(NumOutbox.Text, out colCount)) // x 값을 받았다먼 실행
            {
                return;
            }

            RowLadder RowLadder = new RowLadder(); // RowLadder 클래스를 호출

            RowLadder.ListWrap = colCount - 1;

            // 만들어질 가로 범위 컬럼은 입력 받은 x 의 -1 ex ) 2개를 입력받는다면 1개를 만들어준다.

            RowLadder.Init();

            LadderClear();

            for (int i = 0; i < colCount; i++)
            {
                ColumnSet ColumnL = new ColumnSet();
                Ladders.Children.Add(ColumnL); // Ladder 를 추가
            }
            switch (colCount)
            {
                case 2:
                    RowsPanel.Margin = new Thickness(220, 150, 220, 0);
                    break;
                case 3:
                    RowsPanel.Margin = new Thickness(140, 150, 140, 0);
                    break;
                case 4:
                    RowsPanel.Margin = new Thickness(110, 150, 110, 0);
                    break;
                case 5:
                    RowsPanel.Margin = new Thickness(90, 150, 90, 0);
                    break;

            }
            // x 값을 받아 Column 수 별로 margin 값을 다르게 하였다. 
            // 반응형 기능으로 계산하여 짜야함.





            for (int i = 0; i < RowLadder.ListWrap; i++) // rowWrap 수 만큼 범위를 만들어준다.
            {

                //stringMake(ref RowLadder.rowWrap);

                StackPanel panel = new StackPanel(); // 페널 생성자

                listMake(ref RowLadder.ListWrap);
                

                foreach (int y in RowLadder.allSet[i]) // y 안에 allset 리스트의 난수 i 만큼 넣어준다.
                {
                    Border border = new Border(); // 보더 생성자
                    border.BorderBrush = Brushes.Black; // 보더의 색은 검정

                    //  이 때 Height를 랜덤으로 뽑고 랜덤수를 List에 담아줌

                    border.Height = y; // 보더의 높이 크기는 y 만큼

                    int postY = y;
                    y1Make(ref postY);



                    // list 


                    // 만들 영역의 갯 수의 따라서 사다리 리스트 별로 데이터가 들어간다.




                    border.BorderThickness = new Thickness(0, 0, 0, 5); // 보더의 높이 크기 
                    panel.Children.Add(border); // 보더를 패널의 자식으로 생성한다.

                }
                RowsPanel.Children.Add(panel); //  사다리 만들어주기

            }
        }

        public void listMake(ref int ListNum)
        {
            if (ListNum == 1)
            {
                 void y1Make(ref int i, y)
                {

                }
                List<int> y1 = new List<int>();
                
            }
            else if (ListNum == 2)
            {
                List<int> y1 = new List<int>();
                List<int> y2 = new List<int>();
            }
            else if (ListNum == 3)
            {
                List<int> y1 = new List<int>();
                List<int> y2 = new List<int>();
                List<int> y3 = new List<int>();
            }
            else if (ListNum == 4)
            {
                List<int> y1 = new List<int>();
                List<int> y2 = new List<int>();
                List<int> y3 = new List<int>();
                List<int> y4 = new List<int>();
            }
        }







        /// <summary>
        /// 전에 생성되어있었던 사다리 요소들을 지워주는 메서드 
        /// </summary>
        private void LadderClear()
        {
            Ladders.Children.Clear();
            RowsPanel.Children.Clear();
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        // 모든 사타리들을 지워주는 이벤트 버튼이다.
        {
            // Ladders.Children.Clear(); 모든 요소 지우기
            // Ladders.Children.Remove(ladder); 지정된 요소 지우기  

            RowLadder RowLadder = new RowLadder();
            RowsPanel.Children.Clear();

            if (int.TryParse(NumOutbox.Text, out int result))
            {
                NumOutbox.Text = (result = 2).ToString();

                Ladders.Children.Clear(); // 클릭 할 때 Ladder 를 추가
            }
        }
        // 시작 버튼을 눌렀을 때의 이벤트 버튼이다.
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            // DataToken 알고리즘 

            // 표현 방법 해당 사다리 보더의 색을 바꿔 보이게 한다.

            /*for(int i = 0; i < Start 했을 때의 ; i++)
            {

            }*/
        }
    }
}