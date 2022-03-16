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

namespace WpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        char op = 'o';
        string str;
        int result = 0; 


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            str = calculate.Text;
            if (str.Length != 0)
            {
                try
                {
                    a = Int32.Parse(str);
                    op = '+';
                    calculate.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have to write a number in this!");
                    calculate.Clear();
                }
            } else
            {
                MessageBox.Show("Write something first!");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            str = calculate.Text;
            if (str.Length != 0)
            {
                try
                {
                    a = Int32.Parse(str);
                    op = '-';
                    calculate.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have to write a number in this!");
                    calculate.Clear();
                }
            }
            else
            {
                MessageBox.Show("Write something first!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            str = calculate.Text;
            if (str.Length != 0)
            {
                try
                {
                    a = Int32.Parse(str);
                    op = '*';
                    calculate.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have to write a number in this!");
                    calculate.Clear();
                }
            }
            else
            {
                MessageBox.Show("Write something first!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            str = calculate.Text;
            if (str.Length != 0)
            {
                try
                {
                    a = Int32.Parse(str);
                    op = '/';
                    calculate.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have to write a number in this!");
                    calculate.Clear();
                }
            }
            else
            {
                MessageBox.Show("Write something first!");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (a != 0)
            {
                str = calculate.Text;
                if (str.Length != 0)
                {
                    try
                    {
                        b = Int32.Parse(str);
                        PerformOp(); 
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Error!");                            
                    }
                }
            }
        }
        void PerformOp()
        {
            switch (op) { 
                case '+':
                   result = a + b;
                    MessageBox.Show("result is: " + result);
                    break;
            case '-':
                    result = a - b;
                    MessageBox.Show("result is: " + result);
                    break;
            case '*':
                    result = a * b;
                    MessageBox.Show("result is: " + result);

                    break;
            case '/':
                    result = a / b;
                    MessageBox.Show("result is: " + result);
                    break;
            }
        }
    }
}