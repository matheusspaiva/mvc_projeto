using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ProdutosDao
    {
        public MySqlConnection conexao = new MySqlConnection("SERVER=localhost; DATABASE=mvc_projeto ; UID=root; PWD=; PORT=3306");
       
        public DataTable Buscar()
        {
            DataTable table = new DataTable();
            String sqlstring = "select * from produto";
            MySqlCommand comando = new MySqlCommand(sqlstring, conexao);
            comando.Connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            adapter.Fill(table);
            comando.Connection.Close();
            return table;
        }

        public void Inserir(int id, String nome, int quantidade)
        {
            String sqlstring = $"insert into produto values({id},'{nome}',{quantidade})";
            MySqlCommand comando = new MySqlCommand(sqlstring, conexao);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        public DataTable BuscarId(int id)
        {
            DataTable table = new DataTable();
            String sqlstring = $"select * from produto where id = {id}";
            MySqlCommand comando = new MySqlCommand(sqlstring, conexao);
            comando.Connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            adapter.Fill(table);
            comando.Connection.Close();
            return table;
        }

        public void Update(int id, String nome,int quantidade)
        {
            String sqlstring = $"update produto set nome = '{nome}', quantidade = {quantidade} where id = {id};";
            MySqlCommand comando = new MySqlCommand(sqlstring, conexao);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Delete(int id)
        {
            String sqlstring = $"delete from produto where id = {id};";
            MySqlCommand comando = new MySqlCommand(sqlstring, conexao);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
