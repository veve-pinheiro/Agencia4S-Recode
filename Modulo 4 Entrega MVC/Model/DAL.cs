using MySql.Data.MySqlClient;
using System.Collections.Generic;
using WebApplication3.Model;

namespace WebApplication3.Model
{
    public class DAL
    {
        private string _connectionString = "server=localhost;uid=root;pwd=;database=viagens"; // Ajuste conforme seu banco

        // Método para recuperar todos os destinos
        public List<Destinos> GetTodosDestinos()
        {
            List<Destinos> lst = new List<Destinos>();

            using (var con = new MySqlConnection(_connectionString))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM destinos"; // Consulta os destinos
                var dr = cmd.ExecuteReader(); // Abre o DataReader

                while (dr.Read()) // Lê as linhas
                {
                    var destino = new Destinos()
                    {
                        Id = dr.GetInt32("id"),
                        Cidade = dr.GetString("cidade"),
                        Estado = dr.GetString("estado"),
                        Preco = dr.GetDouble("preco"),
                        Descricao = dr.GetString("descricao")
                    };

                    lst.Add(destino); // Adiciona o destino na lista
                }
                dr.Close();
            }

            return lst;
        }

        // Método para recuperar todas as promoções
        public List<Promocao> GetPromocoes()
        {
            List<Promocao> lst = new List<Promocao>();

            using (var con = new MySqlConnection(_connectionString))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM promocoes"; // Consulta as promoções
                var dr = cmd.ExecuteReader(); // Abre o DataReader

                while (dr.Read()) // Lê as linhas
                {
                    var promocao = new Promocao()
                    {
                        Id = dr.GetInt32("id"),
                        Nome = dr.GetString("nome"),
                        Descricao = dr.GetString("descricao"),
                        Desconto = dr.GetDouble("desconto"),
                        DestinoId = dr.GetInt32("destino_id")
                    };

                    lst.Add(promocao); // Adiciona a promoção na lista
                }
                dr.Close();
            }

            return lst;
        }
    }
}
