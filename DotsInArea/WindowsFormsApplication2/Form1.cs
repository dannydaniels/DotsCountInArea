using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        public static int n;
        public int[,] points;

        public static int shtrih(int[,] points, int n)
        {

            int k = 0;
            int R = 100;
            for (int i = 0; i <= n - 1; i++)
            {
                // Условие с консольной версии     if (points[i, 0] >= -10 && points[i, 0] <= 20 && points[i, 1] <= 10 && points[i, 1] >= 0)       
                // Проверяем попадание точки в квадратную область

                if (points[i, 0] >= -100 && points[i, 0] <= 100 && points[i, 1] >= -100 && points[i, 1] <= 100)
                {
                    k = k + 1;  //Увеличиваем значение на 1, если точка попадает в квадратную область область
                }
                else
                {

                }

            }

            return k;
            
        }
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Refresh();
            pictureBox1.Refresh();

            Graphics g = pictureBox1.CreateGraphics();
            g.TranslateTransform((float)pictureBox1.Width / 2, (float)pictureBox1.Height / 2);
            Rectangle rect = new Rectangle(-100, -100, 200, 200);  //Координаты квадрата 
            g.DrawRectangle(new Pen(Color.Red, .20f), rect);           //Рисуется квадрат
            

            Random rnd = new Random();                                                      //Инициализируем генератор случайных чисел

            points = new int[n, 2];
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    points[i, j] = rnd.Next(-150, 150);       //Цикл заполнения массива случаныйми значениями
                }
            }


            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {

                    Graphics point = pictureBox1.CreateGraphics();
                    point.TranslateTransform((float)pictureBox1.Width / 2, (float)pictureBox1.Height / 2);   //Цикл заполнения области случайными точками
                    point.FillEllipse(Brushes.Black, points[i, 0], points[i, 1], 5, 5);

                }
            }

            int k = shtrih(points, n);            // Присвоение k функции shtrih
            label1.Text = Convert.ToString("Ответ: " + k);  // Вывод результата в label1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);  //Присваевание переменной n, значения из TextBox
            if (string.IsNullOrEmpty(textBox1.Text)) 
            { }
        }

        private void pictureBox1_draw(object sender, EventArgs e)
        {
            
        }

        private void none(object sender, MouseEventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
