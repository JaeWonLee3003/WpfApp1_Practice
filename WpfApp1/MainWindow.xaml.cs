using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        private void StartButton(object sender, RoutedEventArgs e)
        {
            StartBtn startBtn = new StartBtn();
            MessageBox.Show("Hello World");
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

