using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaEscolar.Modelos;

namespace SistemaEscolar.Controllers
{
    class UsuarioController
    {

        String parametros = "server=localhost; userid=root; pwd=123456; database=escola";
        MySqlConnection conexao = null;

        public void conectar()
        {
            conexao = new MySqlConnection(parametros);
        }

        public bool verificaUsuarioBanco(String login, String senha)
        {
            bool verifica = false;
            if (login.Equals("") || senha.Equals(""))
            {
                verifica = false;
            }
            else
            {
                try
                {
                    conectar();
                    MySqlCommand cmd = new MySqlCommand("select login, senha, nome from administrativo where login = '" + login + "' And senha = '" + senha + "'", conexao);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    conexao.Open();

                    MySqlDataReader datareader;
                    datareader = cmd.ExecuteReader();

                    if (datareader.Read())
                    {
                        verifica = true;
                    }

                }
                catch (Exception erro)
                {

                    throw erro;
                }
                finally
                {
                    conexao.Close();
                }
            }

            return verifica;
        }

        public FuncionarioModel usuarioLogado(String login, String senha)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            try
            {
                if (verificaUsuarioBanco(login, senha))
                {
                    conectar();
                    MySqlCommand cmd = new MySqlCommand("select nome from administrativo where login = '" + login + "' AND senha='" + senha + "'", conexao);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    conexao.Open();

                    MySqlDataReader datareader;
                    datareader = cmd.ExecuteReader();

                    while (datareader.Read())
                    {
                        funcionario.Nome = datareader["nome"].ToString();
                    }
                }

            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

            return funcionario;
        }
    }
}
