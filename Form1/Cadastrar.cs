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
    public partial class Cadastrar : Form
    {
        DAO bd;//Chamando a classe DAO
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//Instanciando a variável BD e abrindo a conexão com o banco
        }//fim do construtor

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                //Coletandoos dados da tela para enviar ao banco de dados
                string cpf = RemoverFormatacaoCPF(maskedTextBox1.Text);
                string nomecliente = nome.Text;
                string telefonecliente = telefone.Text;
                string enderecocliente = endereco.Text;

                //Cadastro no banco
                MessageBox.Show(bd.Cadastrar(Convert.ToInt64(cpf), nomecliente, telefonecliente, enderecocliente));

                //LimparTela
                LimparTela();

            }//fim do try
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);   
            }//fim do catch
        }//fim do botão cadastrar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",","");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover

        public void LimparTela()
        {
            maskedTextBox1.Text = "";
            nome.Text = "";
            telefone.Text = "";
            endereco.Text = "";
        }//fim do método

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo CPF

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo telefone

        private void endereco_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo endereco

    }//fim da classe
}//fim do projeto
