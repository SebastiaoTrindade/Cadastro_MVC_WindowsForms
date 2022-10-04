using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;
using Sistema.Entidades;

namespace Sistema.DAO
{
    public class UsuarioDAO
    {
        public int Inserir(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "INSERT INTO usuarios(nome, usuario, senha) VALUES (@nome, @usuario, @senha)";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public List<UsuarioEnt> Pesquisar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE NOME LIKE @NOME";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cmd.Connection = con;

                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["usuarioid"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }

        public int Editar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "UPDATE usuarios SET nome = @nome, usuario = @usuario, senha = @senha where usuarioid = @usuarioid";
                cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cmd.Parameters.Add("usuarioid", SqlDbType.Int).Value = objTabela.Id;
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public int Excluir(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();

                cmd.CommandText = "DELETE FROM USUARIOS WHERE USUARIOID = @USUARIOID";
                cmd.Parameters.Add("UsuarioId", SqlDbType.Int).Value = objTabela.Id;               
                cmd.Connection = con;

                int qtd = cmd.ExecuteNonQuery();

                return qtd;
            }
        }

        public UsuarioEnt Login(UsuarioEnt obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND SENHA = @SENHA";
                cmd.Connection = con;
                cmd.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;

                SqlDataReader dr;              

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();                       
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);                        
                    }
                }
                else
                {
                    obj.Usuario = null;
                    obj.Senha = null;
                }

                return obj;
            }
        }


        public List<UsuarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.CommandText = "SELECT * FROM USUARIOS";                
                cmd.Connection = con;

                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["usuarioid"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }
    }
}
