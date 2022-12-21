using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_T3
{
    public partial class Form1 : Form
    {
        MyLibrary lib = new MyLibrary();
        
        
        string path = "Save.txt";

        public Form1()
        {
            InitializeComponent();
            LoadData();            
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {   
            LibShow();
        }

        private void LibShow()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < lib.Count; i++)
            {                
                listBox1.Items.Add(lib[i].Title);
            }
        }

        private void SaveData()
        {
            using(StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < lib.Count; i++)
                {
                    sw.WriteLine(lib[i].Title);
                    sw.WriteLine(lib[i].Author);
                    sw.WriteLine(lib[i].Description);
                }                
            }
        }

        private void LoadData()
        {
            if(File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string title, author, description;
                    while ((title = sr.ReadLine()) != null && (author = sr.ReadLine()) != null && (description = sr.ReadLine()) != null)
                    {
                        lib.Add(new Book(title, author, description));
                    }
                }                
            }
            else
                File.Create(path).Close();
        }

        public void AddNewBook(string title, string author, string description)
        {
            lib.Add(new Book(title, author, description));
        }

        private void button1_Click(object sender, EventArgs e)//добавить книгу
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            lib.Add(form2.newBook);            
            LibShow();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//Автосохранение при выходе
        {
            SaveData();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//событие смены выделенного элемента 
        {
            int i = listBox1.SelectedIndex; 
            
            textBox1.Text = lib[i].Title;
            textBox2.Text = lib[i].Author;
            richTextBox1.Text = lib[i].Description;
        }

        private void button2_Click(object sender, EventArgs e)// удалить
        {
            int i = listBox1.SelectedIndex;
            if(i >= 0 && i < lib.Count)
            {
                lib.Delete(i);
                LibShow();
            }            
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
