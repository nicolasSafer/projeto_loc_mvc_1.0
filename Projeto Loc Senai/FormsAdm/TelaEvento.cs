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
    public partial class TelaEvento : Form
    {
        public TelaEvento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaCadastroEvento f1 = new TelaCadastroEvento();
            f1.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TelaEditarEvento f2 = new TelaEditarEvento();
            f2.ShowDialog();
        }
    }
}
