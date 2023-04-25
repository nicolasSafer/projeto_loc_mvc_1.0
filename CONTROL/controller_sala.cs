using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace CONTROL
{
   public class controller_sala
    {
        bool resultado = false;
        conexao con = new conexao();

        public bool insertsala(m_sala SL)
        {
            try
            {
                //"insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)"
                string sql = "insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)";
                string[] campos = { "@nome_sala", "@descricao_sala", "@numeracao", "@bloco" };
                string[] valores = { SL.Getnome_sala(), SL.Getdescricao_sala(), SL.Getbloco_sala(), SL.Getnumeracao_sala()};
                if (con.cadastrar(campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public void setbloco_sala(TextBox box_bloco)
        {
            throw new NotImplementedException();
        }

        public void setdescricao_sala(TextBox descricao_sala)
        {
            throw new NotImplementedException();
        }

        public void setnome_sala(TextBox box_nome_sala)
        {
            throw new NotImplementedException();
        }

        public void setnumeracao_sala(TextBox box_numeracao)
        {
            throw new NotImplementedException();
        }
    }
}
