using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using TvOnline.Modelo;
using System.Data;

namespace TvOnline.Repositorio
{
    class TvBD : IDisposable
    {
        private string nomeDB = "TvOnline.db";
        private string strConnection;
        private SQLiteConnection conexao;

        public TvBD()
        {
            strConnection = string.Format("Data Source={0};Version=3", nomeDB);
            if (File.Exists(nomeDB))
            {
                conexao = new SQLiteConnection(strConnection);
                conexao.Open();
                SQLiteCommand sqlite_cmd = conexao.CreateCommand();
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS canal (numero integer primary key, nome varchar(50), tvUrl varchar(200), logoUrl varchar(200), grupo varchar(50), pais varchar(50))";
                //sqlite_cmd.CommandText = "drop table canal";
                sqlite_cmd.Connection = conexao;
                sqlite_cmd.ExecuteNonQuery();
                Dispose();
            }
        }
        
/** METODOS PRIVADOS */

        /// <summary>
        /// Executa a query de inserção ou modificação passada como string
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private bool ExecutaQuery(string query)
        {
            conexao = new SQLiteConnection(strConnection);
            conexao.Open();
            try
            {
                SQLiteCommand comando = new SQLiteCommand(query, conexao);
                comando.Connection = conexao;
                if (comando.ExecuteNonQuery() > 0)
                    return true;
                else 
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("TvDB.ExecutaQuery: "+ ex.Message);
                return false;
                throw;
            }
        }

        /// <summary>
        /// Abre uma conexão, executa a query de leitura passada como string, e fecha conexao
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private SQLiteDataReader ExecutaQueryRetorno(string query)
        {
            conexao = new SQLiteConnection(strConnection);
            conexao.Open();
            SQLiteCommand comando = new SQLiteCommand(query, conexao);
            comando.Connection = conexao;
            return comando.ExecuteReader();
        }


/** METODOS PUBLICOS */

        /// <summary>
        /// Insere um Canal no BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool InsereCanal(Canal c)
        {
            string query = "insert into canal values ";
            query += "(null, '"
                + c.Nome + "', '"
                + c.TvUrl + "', '"
                + c.LogoUrl + "', '"
                + c.Grupo + "', '"
                + c.Pais + "')";
            return ExecutaQuery(query);
        }

        /// <summary>
        /// Busca todos os canais armazenados no BD
        /// </summary>
        /// <returns></returns>
        public List<Canal> BuscaTodosCanais()
        {
            string query = "select * from canal";
            List<Canal> todosCanais = new List<Canal>();
            SQLiteDataReader retorno = ExecutaQueryRetorno(query);

            while (retorno.Read())
            {
                Canal canal = new Canal();
                canal.Numero = retorno.GetInt32(0);
                canal.Nome = retorno.GetString(1);
                canal.TvUrl = retorno.GetString(2);
                canal.LogoUrl = retorno.GetString(3);
                canal.Grupo = retorno.GetString(4);
                canal.Pais = retorno.GetString(5);

                todosCanais.Add(canal);
            }
            return todosCanais;
        }

        /// <summary>
        /// Busca um canal a partir do numero do passado
        /// </summary>
        /// <param name="chNumero">numero do canal a buscar</param>
        /// <returns></returns>
        public Canal BuscaUmCanal(int chNumero)
        {
            Canal canal = null;
            string query = string.Format("select numero, nome, tvUrl, logoUrl, grupo, pais from canal where numero={0}", chNumero);

            SQLiteDataReader retorno = ExecutaQueryRetorno(query);
            while (retorno.Read())
            {
                canal = new Canal();
                canal.Numero = retorno.GetInt32(0);
                canal.Nome = retorno.GetString(1);
                canal.TvUrl = retorno.GetString(2);
                canal.LogoUrl = retorno.GetString(3);
                canal.Grupo = retorno.GetString(4);
                canal.Pais = retorno.GetString(5);
            }
            return canal;
        }

        /// <summary>
        /// Altera o canal passado por parametro no BD
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public bool AlteraUmCanal (Canal ch)
        {
            string query = string.Format("update canal set nome='{0}', tvUrl='{1}', logoUrl='{2}', grupo='{3}', pais='{4}' where numero='{5}'",
                ch.Nome, ch.TvUrl, ch.LogoUrl, ch.Grupo, ch.Pais, ch.Numero);
            return ExecutaQuery(query);
        }

        /// <summary>
        /// Exclui o canal passado como parametro
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public bool ExcluiUmCanal(int numero)
        {
            string query = string.Format("delete from canal where numero={0}", numero);
            return ExecutaQuery(query);
        }

        /// <summary>
        /// Fecha a conexao com o BD
        /// </summary>
        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
