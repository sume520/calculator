using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace 计算器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isNull = false;
        public static double result = 0;
        public bool isDot = false;
        public  static double temp = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "1";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "1";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if ( isNull == false)
                {
                    TBK_Cul.Text = "2";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "2";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "3";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "3";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "4";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "4";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "5";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "5";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if ( isNull == false)
                {
                    TBK_Cul.Text = "6";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "6";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "7";
                    isNull = true;
                    return;
                }
                TBK_Cul.Text += "7";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if ( isNull == false)
                {
                    TBK_Cul.Text = "8";
                    isNull = true;
                    return;
                }
            }
            TBK_Cul.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    TBK_Cul.Text = "9";
                    isNull = true;
                    return;
                }
            }
            TBK_Cul.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (TBK_Cul.Text.Length < 14)
            {
                if (isNull == false)
                {
                    return;
                }

                TBK_Cul.Text += "0";
            }
        }

        private void BTN_plus_Click(object sender, RoutedEventArgs e)
        {
            string num = TBK_num1.Text;
            if (TBK_num1.Text == "")
            {
                TBK_num1.Text = TBK_Cul.Text;
                temp = double.Parse(TBK_Cul.Text);
            }
            else
            {
                TBK_num1.Text += TBK_op.Text + TBK_Cul.Text;
                if (TBK_op.Text == "-")
                    temp -= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "×")
                    temp *=double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "÷")
                    temp /= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "+")
                    temp += double.Parse(TBK_Cul.Text);
            }
            TBK_op.Text = "+";
            isNull = false;
            isDot = false;
        }


        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if(TBK_Cul.Text!="0")
            {
                isDot = false;
                TBK_Cul.Text = TBK_Cul.Text.Remove(TBK_Cul.Text.Length-1,1);
                if (TBK_Cul.Text == "") TBK_Cul.Text = "0";
                for(int i=0;i<TBK_Cul.Text.Length;i++)
                {
                    if (TBK_Cul.Text[i] == '.')
                        isDot = true;
                }
            }
        }

        private void BTN_divede_TouchEnter(object sender, TouchEventArgs e)
        {
            BTN_divede.Background = Brushes.Blue;
        }

        private void BTN_clearall_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            TBK_Cul.Text = "0";
            TBK_op.Text = "";
            TBK_num1.Text = "";
            isDot = false;
            temp = 0;
        }

        private void BTN_sub_Click(object sender, RoutedEventArgs e)
        {
            string num = TBK_num1.Text;
            if (TBK_num1.Text == "")
            {
                TBK_num1.Text = TBK_Cul.Text;
                temp = double.Parse(TBK_Cul.Text);
            }
            else
            {
                TBK_num1.Text += TBK_op.Text + TBK_Cul.Text;
                if (TBK_op.Text == "+")
                    temp += double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "×")
                    temp *= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "÷")
                    temp /= double.Parse(TBK_Cul.Text);
            }
            TBK_op.Text = "-";
            isNull = false;
            isDot = false;
        }

        private void BTN_result_Click(object sender, RoutedEventArgs e)
        {
            if (TBK_num1.Text != "")
            {
                if (TBK_op.Text == "+")
                    result = temp + double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "-")
                    result = temp - double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "×")
                    result = temp * double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "÷")
                    result = temp / double.Parse(TBK_Cul.Text);
                TBK_num1.Text = "";
                TBK_op.Text = "";
                if (result - (int)result > 0)
                    TBK_Cul.Text = result.ToString("F5");
                else
                    TBK_Cul.Text = result.ToString();
                temp = 0;
                isNull = false;
            }
        }

        private void BTN_clearinput_Click(object sender, RoutedEventArgs e)
        {
            TBK_Cul.Text = "0";
            isDot = false;
        }

        private void BTN_mul_Click(object sender, RoutedEventArgs e)
        {
            string num = TBK_num1.Text;
            if (TBK_num1.Text == "")
            {
                TBK_num1.Text = TBK_Cul.Text;
                temp = double.Parse(TBK_Cul.Text);
            }
            else
            {
                TBK_num1.Text += TBK_op.Text + TBK_Cul.Text;
                if (TBK_op.Text == "-")
                    temp -= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "+")
                    temp += double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "÷")
                    temp /= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "×")
                    temp *= double.Parse(TBK_Cul.Text);
            }
            TBK_op.Text = "×";
            isNull = false;
            isDot = false;
        }

        private void BTN_dot_Click(object sender, RoutedEventArgs e)
        {
            if(isDot==false)
            {
                TBK_Cul.Text += ".";
                isDot = true;
            }
        }

        private void BTN_divede_Click(object sender, RoutedEventArgs e)
        {
            string num = TBK_num1.Text;
            if (TBK_num1.Text == "")
            {
                TBK_num1.Text = TBK_Cul.Text;
                temp = double.Parse(TBK_Cul.Text);
            }
            else
            {
                TBK_num1.Text += TBK_op.Text + TBK_Cul.Text;
                if (TBK_op.Text == "-")
                    temp -= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "×")
                    temp *= double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "+")
                    temp += double.Parse(TBK_Cul.Text);
                else if (TBK_op.Text == "÷")
                    temp /= double.Parse(TBK_Cul.Text);
            }
            TBK_op.Text = "÷";
            isNull = false;
        }

        private void BTN_opposite_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(TBK_Cul.Text);
            num = -num;
            TBK_Cul.Text = num.ToString();
        }

        private void BTN_result_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void BTN_result_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void BTN_extract_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}