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


            NumOutbox.TextChanged += NumOutbox_TextChanged;

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
        private void NumOutbox_TextChanged(object sender, TextChangedEventArgs e)
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
                    MessageBox.Show("숫자를 입력해주세요 \nPlease enter a number \n( Tip : 2 ~ 5 )");

                }
            }
            else
            {
                // 문자 일 때 경고 창을 띄워준다.
                MessageBox.Show("숫자를 입력해주세요 \nPlease enter a number");
            }
        }



        /// <summary>
        /// 입력된 갯수 만큼 컬럼을 생성
        /// </summary>
        /// <param name="count">생성할 컬럼의 갯수</param>
        private void ChangeColumn(int count)
        {

        }


        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            

            //Ladders.Children

            
        }

        /// <summary>
        /// 클릭을 하면 숫자가 1이 늘어나고 컬럼이 한개 추가됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlustBtn_Click(object sender, RoutedEventArgs e)
        {

            LadderSet ladder = new LadderSet();

            Ladders.Children.Add(ladder); // 클릭 할 때 Ladder 를 추가 

            // "123"
            if (int.TryParse(NumOutbox.Text, out int result))
            {
                NumOutbox.Text = (result + 1).ToString();
            }
        }
        private void MinustBtn_Click(object sender, RoutedEventArgs e)
        {
            LadderSet ladder = new LadderSet();
            // "123"
            Ladders.Children.Clear();

            if (int.TryParse(NumOutbox.Text, out int result))
            {
                NumOutbox.Text = (result - 1).ToString();
            }
        }
        // 컬럼과 시작,도착 박스를 한 그룹으로 만들고 그것을 복제하고
        // 시작 했을 때 만든 컬럼 첫번쨰 부터 랜덤으로 도착 지점으로 간다. ( 중복 안됨)
        // 

    }
}

