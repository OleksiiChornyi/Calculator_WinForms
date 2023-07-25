using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Calculator
    {
        public double add(double a, double b)
        {
            return a + b;
        }
        public double sub(double a, double b)
        {
            return a - b;
        }
        public double mul(double a, double b)
        {
            return a * b;
        }
        public double div(double a, double b)
        {
            return a / b;
        }
        public double sqr(double a)
        {
            if (a < 0)
                return -1;
            return Math.Sqrt(a);
        }
        public double factorial(double a)
        {
            if (a < 0)
                return -1;
            int factorial = 1;   // значение факториала
            for (int i = 2; i <= a; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        public double cos(double a)
        {
            return Math.Cos(a);
        }
    }
}
