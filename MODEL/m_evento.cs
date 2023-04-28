using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class m_evento
    {
        int id_evento;
        string nome_evento;
        string local_evento;
        string data_evento;
        string horario_evento;
        string descricao_evento;
        public m_evento()
        {

            id_evento = 0;
            nome_evento = "";
            local_evento = "";
            data_evento = "";
            horario_evento = "";
            descricao_evento = "";


        }
        public int id
        {
            get { return id_evento; }
            set { id_evento = value; }
        }
        public string nome
        {
            get { return nome_evento; }
            set { nome_evento = value; }

        }
        public string local
        {
            get { return local_evento; }
            set { local_evento = value; }
        }
        public string data
        {
            get { return data_evento; }
            set { data_evento = value; }
        }
        public string horario
        {
            get { return horario_evento; }
            set { horario_evento = value; }
        }
        public string descricao
        {
            get { return descricao_evento; }
            set { descricao_evento = value; }
        }
    }
}
