using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Control
{
    public class Dql
    {
        readonly AcessoMdf acessoMdf = new AcessoMdf();

        public DataTable ListarTodasPrateleiras()
        {
            try
            {
                acessoMdf.LimparParametros();
                //return acessoMdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, dataEspecionamento, rua, numeroLinha, colEsq, riscoColEsq, diagonal, horizontal, nivelLongarina, t, riscoLongEsq, travaSeguranca, observacaoEsq, nota FROM Localizacao");
                return acessoMdf.ExecutarConsulta(CommandType.Text, "SELECT codigo FROM Localizacao");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //ListarPrateleiras
        //SELECT* FROM Localizacao
    }
}
