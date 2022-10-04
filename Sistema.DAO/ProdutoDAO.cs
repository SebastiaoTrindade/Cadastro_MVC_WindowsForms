using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAO
{
    public class ProdutoDAO
    {
        public int Inserir(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO produtos(nome, descricao, valor) VALUES (@nome, @descricao, @valor)";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cmd.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public List<ProdutoEnt> Pesquisar(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = "SELECT * FROM PRODUTOS WHERE NOME LIKE @NOME";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cmd.Connection = con;

                SqlDataReader dr;
                List<ProdutoEnt> lista = new List<ProdutoEnt>();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProdutoEnt dado = new ProdutoEnt();
                        dado.Id = Convert.ToInt32(dr["produtoid"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }

        public int Editar(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE produtos SET nome = @nome, descricao = @descricao, valor = @valor where produtoid = @produtoid";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cmd.Parameters.Add("valor", SqlDbType.Decimal).Value = objTabela.Valor;
                cmd.Parameters.Add("produtoid", SqlDbType.Int).Value = objTabela.Id;
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public int Excluir(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "DELETE FROM PRODUTOS WHERE PRODUTOID = @PRODUTOID";
                cmd.Parameters.Add("ProdutoId", SqlDbType.Int).Value = objTabela.Id;
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }
                
        public List<ProdutoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = "SELECT * FROM PRODUTOS";
                cmd.Connection = con;

                SqlDataReader dr;
                List<ProdutoEnt> lista = new List<ProdutoEnt>();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProdutoEnt dado = new ProdutoEnt();
                        dado.Id = Convert.ToInt32(dr["produtoid"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }
    }
}
