using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficinAfro_Forms
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            string[] produtos = new string[10];
            double[] valorUn = new double[10];
            int[] estoque = new int[10];
            string[] cod = new string[10];


            produtos[0] = "Camisa Masc Tshirt: ";
            produtos[1] = "Macacão Saruel: ";
            produtos[2] = "Colete Afro: ";
            produtos[3] = "Meia Resistência Afro: ";
            produtos[4] = "Conjunto Masc floral: ";
            produtos[5] = "Kimono Afro ";
            produtos[6] = "Calça jeans skin: ";
            produtos[7] = "Saia longa afro: ";
            produtos[8] = "Moletom Pantera negra: ";
            produtos[9] = "Bata florida solta: "; 
            
            valorUn[0] = 29.90;
            valorUn[1] = 74.99;
            valorUn[2] = 42.90;
            valorUn[3] = 19.90;
            valorUn[4] = 60.00;
            valorUn[5] = 67.99;
            valorUn[6] = 79.90;
            valorUn[7] = 74.90;
            valorUn[8] = 100.00;
            valorUn[9] = 58.90;


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] produtos = new string[10];
            double[] valorUn = new double[10];
            int[] estoque = new int[10];
            string[] cod = new string[10];


            produtos[0] = "Camisa Masc Tshirt: ";
            produtos[1] = "Macacão Saruel: ";
            produtos[2] = "Colete Afro: ";
            produtos[3] = "Meia Resistência Afro: ";
            produtos[4] = "Conjunto Masc floral: ";
            produtos[5] = "Kimono Afro ";
            produtos[6] = "Calça jeans skin: ";
            produtos[7] = "Saia longa afro: ";
            produtos[8] = "Moletom Pantera negra: ";
            produtos[9] = "Bata florida solta: ";

            valorUn[0] = 29.90;
            valorUn[1] = 74.99;
            valorUn[2] = 42.90;
            valorUn[3] = 19.90;
            valorUn[4] = 60.00;
            valorUn[5] = 67.99;
            valorUn[6] = 79.90;
            valorUn[7] = 74.90;
            valorUn[8] = 100.00;
            valorUn[9] = 58.90;

            int qnt  = Convert.ToInt32(textBox1.Text);

            int i;
            double conta;

            for (i = 0; i < 11; i++)
            {
                if (comboBox1.SelectedIndex == i)
                {
                 
                        conta = valorUn[i] * qnt;

                    textBox2.Text = Convert.ToString(conta);
                }

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] valorUn = new double[10];
            valorUn[0] = 29.90;
            valorUn[1] = 74.99;
            valorUn[2] = 42.90;
            valorUn[3] = 19.90;
            valorUn[4] = 60.00;
            valorUn[5] = 67.99;
            valorUn[6] = 79.90;
            valorUn[7] = 74.90;
            valorUn[8] = 100.00;
            valorUn[9] = 58.90;

            int i;

            for (i = 0; i < 11; i++)
            {
                if (comboBox1.SelectedIndex == i)
                {
                    MessageBox.Show(" O valor unitário do produto é: " + valorUn[i]);
                }
            }
        }
    }
}
 