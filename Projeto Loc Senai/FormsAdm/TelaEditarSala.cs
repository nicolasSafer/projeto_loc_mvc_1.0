using CONTROL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaEditarSala : Form
    {
        public string teste;
        public TelaEditarSala(string id)
        {
            teste = id;
            InitializeComponent();
            label5.Text = teste;
            //Desativa barra superior padrão do Windows
            this.Text = string.Empty;
            this.ControlBox = false;
            // Define o tamanho padrão da tela como 1000x600 pixels
            this.MaximumSize = new Size(1000, 650);
            this.MinimumSize = new Size(900, 600);
        }

        //Comando para responsividade da tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cadas_sala_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void cadas_sala_Click(object sender, EventArgs e)
        {

            m_sala sl = new m_sala();
            sl.setnome_sala(box_nome_sala.Text);
            sl.setnumeracao_sala(box_numeracao.Text);
            sl.setbloco_sala(descricao_sala.Text);
            sl.setdescricao_sala(box_bloco.Text);
            controller_sala cs = new controller_sala();
            if (cs.updatesala(sl) == true)
            {
                MessageBox.Show("Deu boa");
            }
            else
            {
                MessageBox.Show("Não deu boa");
            }
        }

        private void TelaEditarSala_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            dtSala.DataSource = conn.ObterDados("SELECT * FROM tb_sala_do_predio where id_sala = @teste");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(teste);
        }
    }
}
