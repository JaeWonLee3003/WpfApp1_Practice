using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();


            //NumOutbox.TextChanged += NumOutbox_TextChanged;

            TestControl();
        }

        

        private void TestControl()
        {
            /*Button button = new Button();
            button.Click += Button_Click;

            TextBox textBox = new TextBox();
            textBox.TextChanged += TextBox_TextChanged;

            RadioButton radioButton = new RadioButton();
            CheckBox checkBox = new CheckBox();
            ToggleButton toggleButton = new ToggleButton();
            radioButton.Checked += RadioButton_Checked;
            radioButton.Unchecked += RadioButton_Unchecked;*/
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

                    ChangeColumn(result); // 2 이상 5라면 값을 result 할당되며 CangeColumn 메소드를 호출함.
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
        /// 입력된 갯수 만큼 컬럼을 생성
        /// </summary>
        /// <param name="count">생성할 컬럼의 갯수</param>
        private void ChangeColumn(int count)
        {
            /*for (int i = 0; i <= count; i++)
            {
                 Console.WriteLine(i); 들어간 숫자만큼 잘 작동하고 있음 
                 count == result 수 만큼 Ladder 가 있어야함 반복 해서 추가하면 중첩이 되면서 쌓임
                 쌓이지 않게 변수를 만들어서 유지 해줘야하는데 방법을 모름.
                 ex : int LadderSetNum = count; Ladder의 갯수는 count와 같다 하고 
                LadderSet ladder = new LadderSet();

                Ladders.Children.Add(ladder); 말고 ladder를 count 만큼 Add 한다면
                제거 했을 때의 갯수도 내려가기에 따라 제거 될 것이다. Add , Remove , Clear 될까?

            }*/

        }
        /// <summary>
        /// 클릭을 하면 숫자가 1이 늘어나고 컬럼이 한개 추가됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetBtn_Click(object sender, RoutedEventArgs e) // 몇 개 만들지 정했음
        {
            GenerateAll();
        }

        private void GenerateAll()
        {
            int x;

            if (!int.TryParse(NumOutbox.Text, out x))
            {
                return;
            }



            RowLadder rowLD = new RowLadder();

            rowLD.rowWrap = x - 1; // 만들어질 가로 범위 컬럼은 입력 받은 x 의 -1 ex ) 2개를 입력받는다면 1개를 만들어준다.
            // 몇 개 만들지는 이제 됐으니까.
            // 리스트에서 0 , 1, 2, 3, 4, 5,  까지 어디서 사다리가 나올지
            // 상수  3이 들어간 rowLine 변수를 List 안에 Random 으로 넣는다.
            // 들어간 배열을 활성화? 시켜줌으로서 보이게한다? 그 배열 위치에 Add? 생성해준다. 

            rowLD.Init();
            

/*
            for (int i = 0; i < rowLD.rowLine; i++)
            {
                // 이 안에서는 라인 3개를 만들어주는 내용이 들어가야한다.
                // 1. 배열 몇번째 인지 0~5 까지 랜덤 메서드를 만들어준다.
                // 2. 무엇`을 삽입을 할 것인지. 무엇을 삽입할 것이냐
                // 가로를 표현 시켜줄 Border를 해당 배열 위치에 Add 해줄 것이다.


                Random randomObj = new Random();

                Console.WriteLine(randomObj.Next(rowLD.rowRanNum));

                // 2042734590 같은 문자가 3번 반복 됨. 

            }
*/
            //rowLD.rows.Add();
            //Console.WriteLine(rowLD.rows);

            Ladders.Children.Clear();
            RowsPanel.Children.Clear();
            for (int i = 0; i < x; i++)
            {
                ColumnSet ColumnL = new ColumnSet();
                Ladders.Children.Add(ColumnL); // 클릭 할 때 Ladder 를 추가
            }
            switch (x)
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

            } // x 값을 받아 만드는 
            
            for (int i = 0; i < rowLD.rowWrap; i++)
            {
                StackPanel panel = new StackPanel();
                foreach(int y in rowLD.allSet[i])
                {
                    Border border = new Border();
                    border.BorderBrush = Brushes.Black;
                    border.Height = y;
                    border.BorderThickness = new Thickness(0, 0, 0, 5);
                    panel.Children.Add(border);
                }
                RowsPanel.Children.Add(panel);
                
            }


                // "123"
                if (int.TryParse(NumOutbox.Text, out int result))
            {
                // NumOutbox.Text = (result + 1).ToString();
            }
        }


        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            ColumnSet ladder = new ColumnSet();

            // "123"
            // Ladders.Children.Clear(); 모든 요소 지우기
            // Ladders.Children.Remove(ladder); 지정된 요소 지    우기  

            RowLadder rowLD = new RowLadder();

            rowLD.rowNum.Clear();
            RowsPanel.Children.Clear();

            Console.WriteLine(rowLD.rowNum);

            if (int.TryParse(NumOutbox.Text, out int result))
            {
                NumOutbox.Text = (result = 2).ToString();

                Ladders.Children.Clear(); // 클릭 할 때 Ladder 를 추가
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // 컬럼과 시작,도착 박스를 한 그룹으로 만들고 그것을 복제하고
        // 시작 했을 때 만든 컬럼 첫번쨰 부터 랜덤으로 도착 지점으로 간다. ( 중복 안됨)
        // 

    }
}

