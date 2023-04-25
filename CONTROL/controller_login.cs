using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace CONTROL
{
    public class controller_login
    {
        bool resultado = false;
        conexao con = new conexao();

        public bool Selectlogin(User us)
        {
            try
            {
                string sql = "INSERT INTO usuario (nome,email,fone) values (@nome,@email,@fone)";
                string[] campos = { "@nome", "@email", "@fone" };
                string[] valores = { us.GetNome(), us.Getemail()};
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

    }
}
