using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaSala : Form
    {
        public TelaSala()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaCadastroSala f1 = new TelaCadastroSala();
            f1.ShowDialog();
        }

        private void BtnAttSala_Click(object sender, EventArgs e)
        {
            TelaEditarSala f2 = new TelaEditarSala();
            f2.ShowDialog();
        }

        private void TelaSala_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtSala.DataSource = conn.ObterDados("SELECT * FROM tb_sala_do_predio");
            //clicar na linha pegar a info do campo id - armazenar em uma variavel - colocar no botão editar troca de tela e levar a variavel e fazer um selecta la com essa variavel
        }
    }
}
