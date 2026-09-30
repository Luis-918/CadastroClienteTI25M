using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botão voltar

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//campo CPF

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                MessageBox.Show(bd.Exluir(cpf));
                //Limpar o campo
                textBox1.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu Errado\n\n" + erro);

            }//fim do catch
        }//fim do botão excluir
    }//fim da classe
}//fim do projeto
