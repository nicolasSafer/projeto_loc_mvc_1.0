using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
