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

namespace WordPad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Cut();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Paste();
        }

        private void catchBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            catchBtn.Margin = new Thickness(rand.Next(0, 150), rand.Next(0, 150), 0, 0);
        }
    }
}
