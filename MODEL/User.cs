using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class User
    {
        public int CodigoUsuario;
        string nome_funcionario;
        string senha_funcionario;
        
        public User()
        {
            //construindo o metodo com as varaiveis vazias
            CodigoUsuario = 0;
            nome_funcionario = "";
            senha_funcionario = "";
            

        }
        public int Codigo
        {
            get { return CodigoUsuario; }
            set { CodigoUsuario = value; }
        }
        public string GetNome()
        {
            return this.nome_funcionario;
        }
        public string Getemail()
        {
            return this.senha_funcionario;
        }
     
        public void setnome(string nome)
        {
            this.nome_funcionario = nome;

        }
        public void setemail(string email)
        {
            this.senha_funcionario = email;
        }
      
    }
}
