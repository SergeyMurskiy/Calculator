using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private bool isCounting = false;

        private void Clear()
        {
            if (isCounting)
            {
                label1.Text = "";
                isCounting = false;
            }
        }

        private static bool Check(char a)
        {
            return "+-/*(".IndexOf(a) != -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "0";
                }
            }
            else
            {
                label1.Text += "0";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();
            
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "1";
                }
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "2";
                }
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "3";
                }
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "4";
                }
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "5";
                }
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "6";
                }
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {
                if (label1.Text[label1.Text.Length - 1] != ')' && label1.Text.Length != 0 && label1.Text[label1.Text.Length - 1] != '0')
                {
                    label1.Text += "7";
                }
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Clear();
            label1.Text = "";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Clear();
            if (label1.Text.Length != 0)
            {
                if (label1.Text[label1.Text.Length - 1] != ')' &&
                    "01234567".IndexOf(label1.Text[label1.Text.Length - 1]) == -1)
                {
                    label1.Text += "(";
                }
            }
            else
            {
                label1.Text += "(";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals("") && label1.Text.Length != 0)
            {
                if (!Check(label1.Text[label1.Text.Length - 1]))
                {
                    label1.Text += ")";
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Clear();
            if (label1.Text.Length != 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {

                if (!Check(label1.Text[label1.Text.Length - 1]))
                {
                    label1.Text += "*";
                }
            }
//            else
//            {
//                label1.Text += "*";
//            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {

                if (!Check(label1.Text[label1.Text.Length - 1]))
                {
                    label1.Text += "/";
                }
            }
//            else
//            {
//                label1.Text += "/";
//            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {

                if (!Check(label1.Text[label1.Text.Length - 1]))
                {
                    label1.Text += "+";
                }
            }
//            else
//            {
//                label1.Text += "+";
//            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Clear();
            if (!label1.Text.Equals(""))
            {

                if (!Check(label1.Text[label1.Text.Length - 1]))
                {
                    label1.Text += "-";
                }
            }
//            else
//            {
//                label1.Text += "-";
//            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            isCounting = true;
            try
            {
                var str = Calculate(label1.Text).ToString();
                label1.Text = str;
            }
            catch (Exception ex)
            {
                label1.Text = "Ошибка!";
            }
        }

        private static byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 6;
            }
        }

        private static bool IsOperator(char с)
        {
            return "+-/*()".IndexOf(с) != -1;
        }

        private static bool IsDelimeter(char c)
        {
            return " =".IndexOf(c) != -1;
        }

        private static double Calculate(string input)
        {
            var output = GetExpression(input);
            var result = Counting(output);
            return result;
        }

        private static string GetExpression(string input)
        {
            var output = string.Empty;
            var operStack = new Stack<char>();

            for (var i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                    continue;

                if (char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " ";
                    i--;
                }

                if (!IsOperator(input[i])) continue;
                if (input[i] == '(')
                    operStack.Push(input[i]);
                else if (input[i] == ')')
                {
                    var s = operStack.Pop();

                    while (s != '(')
                    {
                        output += s.ToString() + ' ';
                        s = operStack.Pop();
                    }
                }
                else
                {
                    if (operStack.Count > 0)
                        if (GetPriority(input[i]) <= GetPriority(operStack.Peek())
                        )
                            output += operStack.Pop() + " ";

                    operStack.Push(
                        char.Parse(input[i]
                            .ToString()));
                }
            }

            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output;
        }

        private static double Counting(string input)
        {
            double result = 0;
            var temp = new Stack<double>();

            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    var a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }

                    temp.Push(double.Parse(a));
                    i--;
                }
                else if (IsOperator(input[i]))
                {
                    var a = temp.Pop();
                    var b = temp.Pop();

                    if (input[i] == '+')
                        result = ConvertTo8(convertTo10(b) + convertTo10(a));
                    else if (input[i] == '-')
                        result = ConvertTo8(convertTo10(b) - convertTo10(a));
                    else if (input[i] == '*')
                        result = ConvertTo8(convertTo10(b) * convertTo10(a));
                    else if (input[i] == '/')
                        result = ConvertTo8(convertTo10(b) / convertTo10(a));

                    temp.Push(result);
                }
            }

            return temp.Peek();
        }

        private static double convertTo10(double a)
        {
            var str = a.ToString().Split(char.Parse(","));
            if (a < 0)
            {
                str[0] = str[0].Substring(1, str[0].Length - 1);
            }

            double result;

            if (str.Length == 1)
            {
                result = str[0].Select((t, i) =>
                    Math.Pow(8, i) * double.Parse(str[0][str[0].Length - (i + 1)].ToString())).Sum();

                if (a < 0)
                {
                    return -1 * result;
                }

                return result;
            }

            var whole = str[0];
            var fractional = str[1];
            result = whole.Select((t, i) => Math.Pow(8, i) * double.Parse(whole[whole.Length - (i + 1)].ToString()))
                         .Sum() + fractional.Select((t, i) => Math.Pow(8, -1 - i) * double.Parse(t.ToString())).Sum();
            if (a < 0)
            {
                return -1 * result;
            }

            return result;
        }

        private static double ConvertTo8(double a)
        {
            var str = a.ToString().Split(char.Parse(","));

            if (a < 0)
            {
                str[0] = str[0].Substring(1, str[0].Length - 1);
            }

            double result;
            if (str.Length == 1)
            {
                var number = int.Parse(str[0]);
                result = ConvertTo8WholePart(number);
                if (a < 0)
                {
                    return -1 * result;
                }

                return result;
            }

            var whole = str[0];
            var fractional = str[1];
            result = ConvertTo8WholePart(int.Parse(whole));
            var tmp = "0,";
            var num = double.Parse("0," + fractional);
            for (var i = 0; i < 5; i++)
            {
                num *= 8;
                tmp += num.ToString().Substring(0, 1);

                var next = num.ToString().Split(char.Parse(","));
                if (next.Length == 1)
                {
                    break;
                }

                num = double.Parse("0," + num.ToString().Split(char.Parse(","))[1]);
            }

            if (a < 0)
            {
                return -1 * (result + double.Parse(tmp));
            }

            return result + double.Parse(tmp);
        }

        private static int ConvertTo8WholePart(int a)
        {
            if (a == 0)
            {
                return 0;
            }

            var inverseResult = "";
            while (a > 0)
            {
                inverseResult += a % 8;
                a /= 8;
            }

            var tmp = "";
            for (var j = 0; j < inverseResult.Length; j++)
            {
                tmp += inverseResult[inverseResult.Length - 1 - j];
            }

            return int.Parse(tmp);
        }
    }
}