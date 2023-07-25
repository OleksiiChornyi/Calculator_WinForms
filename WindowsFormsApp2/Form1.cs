using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double a = 0, b;
        int count;
        string text_coma;
        Calculator operations = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button for closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
        /// <summary>
        /// Button Equal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Equal(object sender, EventArgs e)
        {
            text_coma = textBox1.Text.Replace(".", ",");
            switch (count)
            {
                case 1:
                    if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
                    {
                        textBox1.Text = Convert.ToInt64(operations.add(a, double.Parse(text_coma))).ToString("G4");
                        label1.Text = "Результат:";
                    }
                    else label1.Text = "Введите второе число!";
                    break;
                case 2:
                    if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
                    {
                        textBox1.Text = Convert.ToInt64(operations.sub(a, double.Parse(text_coma))).ToString("G4");
                        label1.Text = "Результат:";
                    }
                    else label1.Text = "Введите второе число!";
                    break;
                case 3:
                    if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
                    {
                        textBox1.Text = Convert.ToInt64(operations.mul(a, double.Parse(text_coma))).ToString("G4");
                        label1.Text = "Результат:";
                    }
                    else label1.Text = "Введите второе число!";
                    break;
                case 4:
                    if (textBox1.Text != "" && textBox1.Text !="NaN" && textBox1.Text != "-")
                    {
                        if (Convert.ToDouble(text_coma) == 0)
                        {
                            textBox1.Text = "NaN";
                            label1.Text = "Деление на ноль невозможно!";
                        }
                        else
                        {
                            textBox1.Text = Convert.ToInt64(operations.div(a, double.Parse(text_coma))).ToString("G4");
                            label1.Text = "Результат:";
                        }
                    }
                    else label1.Text = "Введите второе число!";
                    break;
                default:
                    break;
            }
            a = 0;
        }
        /// <summary>
        /// Button Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
            {
                if (a != 0)
                    button_Equal(sender, e);
                text_coma = textBox1.Text.Replace(".", ",");
                a = double.Parse(text_coma);
                textBox1.Clear();
                count = 1;      
                label1.Text = a.ToString().Replace(",",".") + " +";
            }
            textBox1.Focus();
        }
        /// <summary>
        /// KeyPress on textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.KeyChar = (char)Keys.None;
            if (textBox1.Text.IndexOf("E") != -1)
                e.KeyChar = (char)Keys.None;
            string pattern = "-+,0123456789";// шаблон   
            // запрет ввода символов управления      
            if (!Char.IsControl(e.KeyChar))
                if (pattern.IndexOf(e.KeyChar.ToString()) < 0)
                    e.KeyChar = (char)Keys.None;
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
                (e.KeyChar == (char)Keys.Delete) || (e.KeyChar == ',') ||
                (e.KeyChar == '-') || (e.KeyChar == '+') || (e.KeyChar != '.'))
            {
                string s = textBox1.Text;
                if(s.Length - s.IndexOf(".") > 3 && s.IndexOf(".") != -1)
                    e.KeyChar = (char)Keys.None;
                if(e.KeyChar == (char)Keys.Back)
                {
                    if (textBox1.Text == "NaN")
                    {
                        e.KeyChar = (char)Keys.None;
                        return;
                    }
                    if (textBox1.Text.IndexOf("E") == -1)
                    {
                        int lenght = textBox1.Text.Length - 1;
                        string text = textBox1.Text;
                        textBox1.Clear();
                        for (int i = 0; i < lenght; i++)
                        {
                            textBox1.Text = textBox1.Text + text[i];
                        }
                    }
                    else
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == ',' && (textBox1.Text == "" || textBox1.Text =="NaN"))
                {
                    e.KeyChar = (char)Keys.None;
                }
                else if (e.KeyChar == ',' && textBox1.Text != "")
                {
                    int i = s.IndexOf(".");
                    if (i != -1)
                    {
                        e.KeyChar = (char)Keys.None;
                    }
                }
                if (e.KeyChar == '-' || e.KeyChar == '+')
                {
                    s = textBox1.Text;
                    int i = s.Length;
                    if (i > 0) e.KeyChar = (char)Keys.None;
                }
            }
            else
                e.KeyChar = (char)Keys.None;
        }
        /// <summary>
        /// Button for Minus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Minus(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
            {
                if (a != 0)
                    button_Equal(sender, e);
                text_coma = textBox1.Text.Replace(".", ",");
                a = double.Parse(text_coma);
                textBox1.Clear();
                count = 2;
                label1.Text = a.ToString().Replace(",", ".") + " -";
            }
            textBox1.Focus();
        }
        /// <summary>
        /// Button for Multiplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Mul(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "NaN" && textBox1.Text != "-")
            {
                if (a != 0)
                    button_Equal(sender, e);
                text_coma = textBox1.Text.Replace(".", ",");
                a = double.Parse(text_coma);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString().Replace(",", ".") + " *";
            }
            textBox1.Focus();
        }
        /// <summary>
        /// Button for Divide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Divide(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN" || textBox1.Text == "-")
                return;
            text_coma = textBox1.Text.Replace(".", ",");
            if (Convert.ToDouble(text_coma) != 0)
            {
                if (a != 0)
                    button_Equal(sender, e);
                a = double.Parse(text_coma);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString().Replace(",", ".") + " /";
            }
            textBox1.Focus();
        }
        /// <summary>
        /// Button 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_9(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        /// <summary>
        /// Button 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_0(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        /// <summary>
        /// Button 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        /// <summary>
        /// Button 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        /// <summary>
        /// Button 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_3(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        /// <summary>
        /// Button 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_4(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        /// <summary>
        /// Button 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_5(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        /// <summary>
        /// Button 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_6(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        /// <summary>
        /// Button 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_7(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        /// <summary>
        /// Button 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_8(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        /// <summary>
        /// Button for clear TextBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear(object sender, EventArgs e)
        {
            a = 0;
            textBox1.Clear();
            label1.Text = "";
        }
        /// <summary>
        /// Button Backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Backspace(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
                return;
            if (textBox1.Text.IndexOf("E") == -1)
            {
                int lenght = textBox1.Text.Length - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }        
        }
        /// <summary>
        /// Button Minus/Plus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Minus_Plus(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN")
                return;
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
        /// <summary>
        /// Textchanges on TextBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text, text = textBox1.Text;
            int length = textBox1.Text.Length - 1;         
            if (s.Length - s.IndexOf(".", 0, s.Length) > 4 && s.IndexOf(".", 0, s.Length) != -1 && s.IndexOf("E") == -1)
            {
                textBox1.Clear();
                for (int i = 0; i < length; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }
            if (textBox1.Text.IndexOf("E") != -1)
            {
                s = "";
                for (int i = 0; i < textBox1.Text.IndexOf("E")+4; i++)
                {
                    s += text[i];
                }
                textBox1.Text = s;
            }
            if (textBox1.Text != "" && textBox1.Text.IndexOf("E") == -1 && textBox1.Text.IndexOf("NaN") == -1 && textBox1.Text != "-" && textBox1.Text != "." && textBox1.Text != ",")
            {
                string s1 = textBox1.Text.Replace(".", ",");
                if (Convert.ToDouble(s1) > 500000 || Convert.ToDouble(s1) < -300000)
                {
                    s = "";
                    for (int i = 0; i < length; i++)
                    {
                        s += text[i];
                        s1 = s;
                    }
                    textBox1.Text = s1;
                }             
            }
            if (textBox1.Text.IndexOf("NaN") == 0 && textBox1.Text.Length == 4)
            {
                s = textBox1.Text.Substring(3, 1);
                textBox1.Clear();
                textBox1.Text = s;
                label1.Text = "";
            }
            textBox1.Text = textBox1.Text.Replace(",", ".");
            textBox1.Focus();
            textBox1.Select(textBox1.Text.Length, 0);
        }
        /// <summary>
        /// Button for SQRT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SQRT(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN" || textBox1.Text == "-")
                return;
            text_coma = textBox1.Text.Replace(".", ",");
            b = Convert.ToInt32(operations.sqr(double.Parse(text_coma)));
            if (b == -1)
            {
                textBox1.Text = "NaN";
                label1.Text = "Корень от отрицательного числа неопределён!";
            }
            else
            {
                textBox1.Text = b.ToString("G4");
                label1.Text = "Результат:";
            }
        }
        /// <summary>
        /// Button for cosinus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_COS(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN" || textBox1.Text == "-")
                return;
            text_coma = textBox1.Text.Replace(".", ",");
            textBox1.Text = Convert.ToInt64(operations.cos(double.Parse(text_coma))).ToString("G4");
            label1.Text = "Результат:";
        }
        /// <summary>
        /// Button for factorial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_factorial(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN" || textBox1.Text == "-")
                return;
            text_coma = textBox1.Text.Replace(".", ",");
            long x = Convert.ToInt64(operations.factorial(double.Parse(text_coma)));
            if (x == -1)
            {
                textBox1.Text = "NaN";
                label1.Text = "Факториал от отрицательного числа неопределён!";
            }
            else
            {
                textBox1.Text = x.ToString("G4");
                label1.Text = "Результат:";
            }
        }
        /// <summary>
        /// KeyUp delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (textBox1.Text.IndexOf("E") == -1)
                {
                    int lenght = textBox1.Text.Length - 1;
                    string text = textBox1.Text;
                    textBox1.Clear();
                    for (int i = 0; i < lenght; i++)
                    {
                        textBox1.Text = textBox1.Text + text[i];
                    }
                }
            }
        }

        /// <summary>
        /// Button for comma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_comma(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "NaN")
                return;
            int comma = 0;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text.Contains("."))
                    {
                        comma = 1;
                    }
                }
                if (comma == 0) textBox1.Text = textBox1.Text + ".";           
        }
    }
}
