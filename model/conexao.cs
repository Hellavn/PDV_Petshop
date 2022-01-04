using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Petshop
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(); 
        //construtor da classe
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-E71FRID\SQLEXPRESS;Initial Catalog=petshop;Integrated Security=True";
        }

        //metodo para conectar ao banco de dados
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //metodo para desconectar do banco de dados

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
