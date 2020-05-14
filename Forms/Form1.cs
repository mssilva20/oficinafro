using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace oficinAfro_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            bool generoF;
            bool generoM;

            nome = textBox1.Text;
            generoF = radioButton1.Checked;
            generoM = radioButton2.Checked;

            if (radioButton1.Checked == true)
            {
                
                MessageBox.Show("Olá, " + nome + ". Seja Bem vinda á OficinAfro!");
              
                Produtos OutroForm = new Produtos();
                OutroForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Olá, " + nome + ". Seja Bem vindo á OficinAfro!");
               
                Produtos OutroForm = new Produtos();
                OutroForm.ShowDialog();
                this.Close();
            }
        }

        private void NovoForms()
        {
            Application.Run(new Produtos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
