using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // генерация ключе n,d,e
        private void button1_Click(object sender, EventArgs e)
        {
            KeyCollection.KeyColl();// нахождение ключей n,d,e
            textBox3.Text = Convert.ToString(KeyCollection.ee);// вывод ключа e
            textBox2.Text = Convert.ToString(KeyCollection.d);// вывод ключа d 
            textBox1.Text = Convert.ToString(KeyCollection.n);// вывод ключа n
            button2.Enabled = true;
        }

        // Шифрование
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = EncriptAndDecript.Encript(richTextBox1.Text);
        }

        // Рисшифровать
        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                MessageBox.Show("Введите ключ(и)!");
            else if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                KeyCollection.n = Convert.ToInt32(textBox1.Text);
                KeyCollection.d = Convert.ToInt32(textBox2.Text);
                KeyCollection.ee = Convert.ToInt32(textBox3.Text);
            }
            else
                MessageBox.Show("Введите ключ(и)!");

            richTextBox1.Text = EncriptAndDecript.Decript(richTextBox2.Text);
        }

        // проверка поля ключа n на вводимость только цифр и Backspace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        // проверка поля ключа d на вводимость только цифр и Backspace
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        // проверка поля ключа e на вводимость только цифр и Backspace
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
