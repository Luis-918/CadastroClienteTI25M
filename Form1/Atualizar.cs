using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Atualizar : Form
    {
        DAO bd;
        Cadastrar cad;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
            cad = new Cadastrar();
        }//fim do construtor

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Campo CPF 

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Campo Campo

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Campo Novo Dado

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long cpf = Convert.ToInt64(cad.RemoverFormatacaoCPF(maskedTextBox1.Text));
                string campo = maskedTextBox2.Text;
                string novodado = textBox4.Text;
                //Atualizar
                MessageBox.Show(bd.Atualizar(cpf, campo, novodado));
                //Limpar a tela
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                textBox4.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu erradon\n\n" + erro);
            }


        }//fim do botão atualizar
    }//fim da classe
}//fim do projeto
