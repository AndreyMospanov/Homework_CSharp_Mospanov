using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_T3
{
    public partial class Form2 : Form
    {
        public Book newBook = new Book();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty)
            {
                newBook.Title = textBox1.Text;
                newBook.Author = textBox2.Text;
                newBook.Description = textBox3.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Все строки должны быть заполнены");
            }
        }
    }
}
