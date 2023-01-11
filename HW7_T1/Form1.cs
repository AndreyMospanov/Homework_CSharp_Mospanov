using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_T1
{
    public partial class Form1 : Form
    {
        Converter converter = new Converter();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from;
            string to;
            string input = textBox1.Text;
            string output = string.Empty;
            if (input == String.Empty)
            {
                MessageBox.Show("Введите число");
                return;
            }
            if(comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Разрядность переводимых чисел не выбрана");
            }
            from = comboBox1.SelectedItem.ToString();// выбор параметров  
            to = comboBox2.SelectedItem.ToString(); //из комбо-боксов №№1, 2
            
            if (from == "Десятичные")
            {
                if(to == "Двоичные")
                {
                    output = converter.DecToBinary(textBox1.Text);
                }   
                if(to == "Шестнадцатиричные")
                {
                    output = converter.DecToHex(textBox1.Text);
                }
                if (to == "Десятичные")
                {
                    output = input;
                }
            }
            else if(from == "Двоичные")
            {
                if (to == "Двоичные")
                {
                    output = input;
                }
                if (to == "Шестнадцатиричные")
                {
                    string temp;
                    temp = converter.BinaryToDec(input).ToString();
                    output = converter.DecToHex(temp);
                }
                if (to == "Десятичные")
                {
                    output = converter.BinaryToDec(input).ToString();
                }
            }
            else if (from == "Шестнадцатиричные")
            {
                if (to == "Двоичные")
                {
                    string temp;
                    temp = converter.HexToDec(input).ToString();
                    output = converter.DecToBinary(temp);
                }
                if (to == "Шестнадцатиричные")
                {
                    output = input;
                }
                if (to == "Десятичные")
                {
                    output = converter.HexToDec(input).ToString();
                }
            }
            else
            {
                MessageBox.Show("Ошибка перевода");
            }

            textBox2.Text = output;
        }
    }
}
