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
    /// <summary>
    /// LadderSet.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LadderSet : UserControl
    {
        public LadderSet()
        {
            InitializeComponent();
        }

        private void StartBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            int latterNum = StartInBox.Text.Length;

            if (latterNum == 0)
            {
                MessageBox.Show("비어있습니다.");
                StartInBox.Text = "직접 입력";
            }
            else if (latterNum >= 12)
            {
                MessageBox.Show("수가 너무 많습니다.");
                StartInBox.Text = "직접 입력";



            }
        }

        private void EndBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
