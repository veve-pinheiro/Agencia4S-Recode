//Ivan Luís Süptitz (02/09/2020)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebApplication3.Model
{
    public class DAL
    {
        public List<Destinos> GetTodosJogadores()
        {
            List<Destinos> lst = new List<Destinos>();

            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwr=;database=clube");
            con.Open(); //abrir a conexão

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM jogador";//especifico a consulta
            var dr = cmd.ExecuteReader();//abre o datareader
            while (dr.Read())//se posiciona na linha seguinte
            {
                var j = new Destinos();
                j.Nome = dr.GetString("nome");
                j.Idade = dr.GetInt32("idade");
                j.Posicao = dr.GetString("posicao");

                lst.Add(j);//adicionando o jogador na lista
            }
            dr.Close();//fechar o datareader
            con.Close();//fechar a conexão

            return lst;
        }
    }
}
