using Control.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Control
{
    public class AcessoMdf
    {
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.connectionstringprateleira);
        }

        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(String nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        public object ExecutarManipulacao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {

                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                sqlCommand.ExecuteScalar();
                sqlConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                //foreach (SqlParameter sqlParameter in sqlParameterCollection)
                //{
                //    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                //}

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
