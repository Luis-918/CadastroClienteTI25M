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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Mostrar a Tela
        }//fim do método cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();//Mostrar a Tela
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();//Mostrar a Tela
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();//Mostrar a Tela
        }
    }
}
