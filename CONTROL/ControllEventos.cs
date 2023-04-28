using MODEL;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace CONTROL
{
    
    public class ControllEventos
    {
        bool resultado = false;
        string sql;
        conexao con = new conexao();
        public bool cadastrar(m_evento evento)
        {
            try
            {
                //"insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)"
                sql = "insert into tb_evento(nome_evento,local_evento,data_evento,horario_evento,descricao_evento) values (@nome,@local,@data,@horario,@descricao)";
                string[] campos = { "@nome", "@local", "@data", "@horario", "@descricao" };
                string[] valores = { evento.nome, evento.local, evento.data, evento.horario, evento.descricao };
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
        public bool updatesala(m_sala ums)
        {
            try
            {
                string sql = "UPDATE tb_sala_do_predio set nome_sala = @nome_sala, descricao_sala = @descricao_sala, numeracao = @numeracao, bloco = @bloco where id_sala=@codigo";
                string[] campos = { "@nome_sala", "@descricao_sala", "@numeracao", "@bloco" };//falta o id_sala
                string[] valores = { ums.Getnome_sala(), ums.Getdescricao_sala(), ums.Getnumeracao_sala(), ums.Getbloco_sala() };
                if (con.atualizarDados(ums.codigosala, campos, valores, sql) >= 1)
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
        public bool ExcluiSala(m_sala sala)
        {
            sql = "delete from tb_sala_do_predio where id_sala = @codigo";
            try
            {
                con.apagar(sala.codigosala, sql);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
            
     }
}

