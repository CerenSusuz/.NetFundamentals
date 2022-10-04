using ProjectConcat;
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
using System.Windows.Shapes;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }

        //private void Send_Click(object sender, RoutedEventArgs e)
        //{
        //    MainWindow username = new MainWindow();
        //    username.TextBlockName.Text = textBox1.Text;
        //    username.Show(); //Sending value from one form to another form.
        //    Close();
        //}

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            MainWindow username = new MainWindow();
            username.TextBlockName.Text = textBox1.Text;

            ConcatLogic concatenationLogic = new ConcatLogic();

            string result = concatenationLogic.Concat(Convert.ToString(username.TextBlockName.Text));
            username.TextBlockName.Text = result;

            username.Show(); //Sending value from one form to another form.
            Close();
        }
    }
}
