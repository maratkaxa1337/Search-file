using System;
using System.Windows.Forms;
using System.IO; 


namespace Программа_марата
{
    public partial class Form1 : Form
    {
        string Cher = "\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

         void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = (FBD.SelectedPath);
                textBox2.Text = textBox3.Text + Cher + textBox1.Text;
            }
        }

         void button3_Click(object sender, EventArgs e)

        {
            textBox2.Text = textBox3.Text + Cher + textBox1.Text;
            if (File.Exists(textBox2.Text))
            {
                Method("Файл есть");
            }
            else
                Method("Файла нет");
        }
        void Method(string line)
        {
            MessageBox.Show(line, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


    }
}
