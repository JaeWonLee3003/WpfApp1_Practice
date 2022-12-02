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
            init();

            NumOutbox.TextChanged += NumOutbox_TextChanged;

            TestControl();
        }

        private void TestControl()
        {
            Button button = new Button();
            button.Click += Button_Click;

            TextBox textBox = new TextBox();
            textBox.TextChanged += TextBox_TextChanged;

            RadioButton radioButton = new RadioButton();
            CheckBox checkBox = new CheckBox();
            ToggleButton toggleButton = new ToggleButton(); 

            radioButton.Checked += RadioButton_Checked;
            radioButton.Unchecked += RadioButton_Unchecked;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }


        
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
                if(result >= startBox.SetBoxMIN && result <= startBox.SetBoxMAX) // 예외처리 2 이상 5 이하
                {
                    ChangeColumn(result); // 2 이상 5라면 값을 result 할당되며 CangeColumn 메소드를 호출함.
                }
            }
            else
            {
                // 문자일 떄 
            }
        }



        /// <summary>
        /// 입력된 갯수 만큼 컬럼을 생성
        /// </summary>
        /// <param name="count">생성할 컬럼의 갯수</param>
        private void ChangeColumn(int count) 
        {

        }

        private void init()
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /*private void title(object sender, RoutedEventArgs e)
        {
            TitleText titleText = new TitleText();
        }*/

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// 클릭을 하면 숫자가 1이 늘어나고 컬럼이 한개 추가됨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlustBtn_Click(object sender, RoutedEventArgs e)
        {
            // "112"
            if (int.TryParse(NumOutbox.Text, out int result))
            {
                NumOutbox.Text = (result+ 1).ToString();
            }
        }

        /*private void plus_Click(object sender, RoutedEventArgs e)
        {
            int ori = int.Parse(numbox.Text); // "0" string -> int 0
            int target = ori + 1; // 1
            numbox.Text = target.ToString();


            //MessageBox.Show("Hello World");
            //outputTb.Text = mytb.Text;
            //outputTb.FontSize += 2;
            //Grid.SetColumn(mytb, 0);
            //mytb.Text = "Hello World";

        }*/


        /*private void minus_Click(object sender, RoutedEventArgs e)
        {
            int ori = int.Parse(numbox.Text); // "0" string -> int 0
            int target = ori - 1; // 1
            numbox.Text = target.ToString();
        }*/
    }
}

