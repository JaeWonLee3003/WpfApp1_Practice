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
            EmptyStartText();

        }

        public void EmptyStartTex()
        {
            if (StartInBox.Text.Length == 0)
            {
                MessageBox.Show("비어 있는 텍스트가 있습니다.");
            }
            if (StartInBox.Text.Length > 12)
            {

                MessageBox.Show("텍스트가 너무 긴 것이 있습니다.");
            }
        }

        public static void EmptyStartText()
        {
            
        }
        private void EndBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}