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
        public Dictionary<string, string> ResgatarInfo()
        {
            var infos = new Dictionary<string, string>();
            var teste = new Endereco();
            string sql = $"SELECT cep, estado, bairro FROM {teste.ObterNomeTabela()} WHERE id_cliente='{Form1.cliente.Id}'";
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
                            infos.Add(dr[0].ToString(),$"{dr[1].ToString()} , {dr[2].ToString()}");
                        }
                        return infos;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
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
        private Dictionary<string, object> ObterColunaValor()
        {
            var colunas = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var colunaValor = new Dictionary<string, object>();
            foreach (var coluna in colunas)
            {
                var nomeColuna = ObterNomeColuna(coluna);
                if (string.IsNullOrEmpty(nomeColuna)) continue;
                var valorColuna = coluna.GetValue(this);
                if (!ObterValidacao(valorColuna)) continue;
                colunaValor.Add(nomeColuna, valorColuna);
            }
            return colunaValor;
        }
        private string ObterNomeColuna(PropertyInfo coluna)
        {
            var tableAttributes = (TableAttribute[])coluna.GetCustomAttributes<TableAttribute>();
            var nomeColuna = string.Empty;
            foreach (var tableAttribute in tableAttributes)
            {
                if (tableAttribute.NaoLevar) return String.Empty;
                if (tableAttribute.Requirido && !ObterValidacao(coluna.GetValue(this))) throw new Exception($"Atributo {nomeColuna} é requirido e está nulo.");
                if (string.IsNullOrEmpty(tableAttribute.Nome)) continue;
                else nomeColuna = tableAttribute.Nome;
            }
            return nomeColuna;
        }
        private bool ObterValidacao(object valorColuna)
        {
            if (valorColuna == null) return false;
            if (valorColuna.GetType() == typeof(string) && (string)valorColuna == string.Empty) return false;
            if (valorColuna.GetType() == typeof(int) && (int)valorColuna == -1) return false;
            if (valorColuna.GetType() == typeof(Guid) && (Guid)valorColuna == Guid.Empty) return false; //proteção guid especifico
            return true;
        }
        private string ObterStringConexao()
        {
            return ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }
    }
}
