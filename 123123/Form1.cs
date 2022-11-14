using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _123123
{
    public partial class Form1 : Form
    {

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
        {
            

            for (int x = 1; x < 11; x++)
            {
                listBox1.Items.Add(x);
            }
            var fn = Outer();

            Action Outer()  // метод или внешняя функция
            {
                int x = 1;  // лексическое окружение - локальная переменная
                void Inner()    // локальная функция
                {
                    x++;        // операции с лексическим окружением
                    Console.WriteLine(x);
                }
                return Inner;   // возвращаем локальную функцию   
            }

        }  

    }
}
