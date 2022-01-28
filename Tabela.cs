using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientesWF
{
    public abstract class Tabela<T>
    {
        public virtual Guid Id { set; get; }
        public void Salvar()
        {
            Dictionary<string, object> colunasValor = ObterColunaValor();
            var parametros = colunasValor.Keys;
            string sql = $"insert into {ObterNomeTabela()} ({string.Join(",", parametros)}) values (@{string.Join(",@", parametros)})";
            using (var conn = ObterConexao())
            {
                var cmd = new SqlCommand(sql, conn);
                foreach (var item in colunasValor)
                    cmd.Parameters.AddWithValue($"@{item.Key}", $"{item.Value}");
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
        public List<T> ObterDados(List<string> parametros, Guid id, string campoVinculado)
        {
            string sql;
            var retorno = new List<T>();
            if (id == Guid.Empty || string.IsNullOrEmpty(campoVinculado)) sql = $"SELECT {string.Join(",", parametros)} FROM {ObterNomeTabela()}";
            else sql = $"SELECT {string.Join(",", parametros)} FROM {ObterNomeTabela()} WHERE {campoVinculado}='{id}'";
            using (var conn = ObterConexao())
            {
                try
                {
                    var cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T obj = (T)Activator.CreateInstance(typeof(T));
                            var colunas = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                            foreach (var coluna in colunas)
                            {
                                string nomeColuna = ObterNomeColuna(coluna, false);
                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    if (dr.GetName(i) == nomeColuna && dr[nomeColuna] != DBNull.Value)
                                    {
                                        coluna.SetValue(obj, dr[nomeColuna], null);
                                    }
                                }
                            }
                            retorno.Add(obj);
                        }
                        return retorno;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
        public List<T> ObterDados()
        {
            var parametros = new List<string>();
            var colunas = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            string nomeColuna;
            foreach (var coluna in colunas)
            {
                nomeColuna = ObterNomeColuna(coluna, false);
                if (string.IsNullOrEmpty(nomeColuna)) continue;
                else parametros.Add(ObterNomeColuna(coluna, false));
            }
            return ObterDados(parametros, Guid.Empty, string.Empty);
        }
        private SqlConnection ObterConexao()
        {
            var stringConexao = ObterStringConexao();
            return new SqlConnection(stringConexao);
        }
        private string ObterNomeTabela()
        {
            var tableAttribute = typeof(T).GetCustomAttribute<TableAttribute>();
            if (tableAttribute == null || String.IsNullOrEmpty(tableAttribute.Nome))
            {
                return typeof(T).Name.ToLower() + "s";
            }
            return tableAttribute.Nome;
        }
        private Dictionary<string, object> ObterColunaValor(bool valid = true)
        {
            var colunas = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var colunaValor = new Dictionary<string, object>();
            foreach (var coluna in colunas)
            {
                var nomeColuna = string.Empty;
                if (valid) nomeColuna = ObterNomeColuna(coluna);
                //else nomeColuna = ObterNomeColunaHistorico(coluna);
                if (string.IsNullOrEmpty(nomeColuna)) continue;
                var valorColuna = coluna.GetValue(this);
                if (!ObterValidacao(valorColuna)) continue;
                colunaValor.Add(nomeColuna, valorColuna);
            }
            return colunaValor;
        }
        private string ObterNomeColuna(PropertyInfo coluna, bool validacao = true)
        {
            var tableAttributes = (TableAttribute[])coluna.GetCustomAttributes<TableAttribute>();
            var nomeColuna = string.Empty;
            foreach (var tableAttribute in tableAttributes)
            {
                if (validacao && tableAttribute.NaoLevar) return string.Empty;
                if (validacao && tableAttribute.Requirido && !ObterValidacao(coluna.GetValue(this))) throw new Exception($"Atributo {nomeColuna} é requirido e está nulo.");
                if (string.IsNullOrEmpty(tableAttribute.Nome)) continue;
                else nomeColuna = tableAttribute.Nome;
            }
            return nomeColuna;
        }
        private bool ObterValidacao(object valorColuna)
        {
            if (valorColuna is null) return false;
            if (valorColuna is string && valorColuna as string is "") return false;
            if (valorColuna is int && (int)valorColuna is -1) return false;
            if (valorColuna is Guid && (Guid)valorColuna == Guid.Empty) return false; //proteção guid especifico
            return true;
        }
        private string ObterStringConexao()
        {
            return ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }
    }
}
