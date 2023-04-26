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
        public bool updatesala(m_sala sl)
        {
            try
            {
                //UPDATE tb_sala_do_predio set nome_sala = @nome_sala, descricao_sala = @descricao_sala, numeracao = @numeracao, bloco = @bloco WHERE tb_sala_do_predio.id_sala = @id_on
                string sql = "UPDATE tb_sala_do_predio set nome_sala = @nome_sala, descricao_sala = @descricao_sala, numeracao = @numeracao, bloco = @bloco where id_sala=@id_sala";
                string[] campos = { "@nome_sala", "@descricao_sala", "@numeracao", "@bloco" };//falta o id_sala
                string[] valores = { sl.Getnome_sala(), sl.Getdescricao_sala(), sl.Getbloco_sala(), sl.Getnumeracao_sala() };
                if (con.atualizarDados(sl.Codigosala, campos, valores, sql) >= 1)//criar o codigo sala no model
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
                throw ex;

            }
        }

    }
}
