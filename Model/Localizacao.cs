using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;

namespace Model
{
    public class Localizacao
    {
        private int codigo;
        private DateTime dataEspecionamento;

        //DADOS DO CLIENTE private string cliente;

        /*
         * classe clinte
         * cnpj
         * endereço
         * armazem -- Já tudo pronto.
        */

        private string rua;
        private int numeroLinha; //NLE - Verificação se está torta ou não
        private string colEsq;   //Traseira e Frontal
        private string riscoColEsq;
        private int diagonal;    //Diag
        private int horizontal;
        private int nivelLongarina;
        private string t;
        private string riscoLongEsq; //bom, ruim, mais detalhes (verde amarelho vermelho VD AM VM)
        private int travaSeguranca;
        private string observacaoEsq;
        private int nota;

        public Localizacao(int codigo, DateTime dataEspecionamento, string rua, int numeroLinha, string colEsq, string riscoColEsq, int diagonal, int horizontal, int nivelLongarina, string t, string riscoLongEsq, int travaSeguranca, string observacaoEsq, int nota)
        {
            this.Codigo = codigo;
            this.DataEspecionamento = dataEspecionamento;
            this.Rua = rua;
            this.NumeroLinha = numeroLinha;
            this.ColEsq = colEsq;
            this.RiscoColEsq = riscoColEsq;
            this.Diagonal = diagonal;
            this.Horizontal = horizontal;
            this.NivelLongarina = nivelLongarina;
            this.T = t;
            this.RiscoLongEsq = riscoLongEsq;
            this.TravaSeguranca = travaSeguranca;
            this.ObservacaoEsq = observacaoEsq;
            this.Nota = nota;
        }

        public Localizacao()
        {

        }

        public Localizacao(int codigo)
        {
            Codigo = codigo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime DataEspecionamento { get => dataEspecionamento; set => dataEspecionamento = value; }
        public string Rua { get => rua; set => rua = value; }
        public int NumeroLinha { get => numeroLinha; set => numeroLinha = value; }
        public string ColEsq { get => colEsq; set => colEsq = value; }
        public string RiscoColEsq { get => riscoColEsq; set => riscoColEsq = value; }
        public int Diagonal { get => diagonal; set => diagonal = value; }
        public int Horizontal { get => horizontal; set => horizontal = value; }
        public int NivelLongarina { get => nivelLongarina; set => nivelLongarina = value; }
        public string T { get => t; set => t = value; }
        public string RiscoLongEsq { get => riscoLongEsq; set => riscoLongEsq = value; }
        public int TravaSeguranca { get => travaSeguranca; set => travaSeguranca = value; }
        public string ObservacaoEsq { get => observacaoEsq; set => observacaoEsq = value; }
        public int Nota { get => nota; set => nota = value; }

        public List<Localizacao> ListarPrateleiras()
        {
            try
            {
                AcessoMdf acessoMdf = new AcessoMdf();
                acessoMdf.LimparParametros();

                List<Localizacao> localizacoes = new List<Localizacao>();

                //PASSAR QUERY PARA DQL (DATA QUERY LANGUAGE)
                DataTable dataTableLocalizacoes = acessoMdf.ExecutarConsulta(CommandType.Text, "SELECT * FROM Localizacao");

                foreach (DataRow linha in dataTableLocalizacoes.Rows)
                {
                    //Localizacao localizacao = new Localizacao(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["dataEspecionamento"]), linha["rua"].ToString(), Convert.ToInt32(linha["numeroLinha"]), linha["colEsq"].ToString(), linha["riscoColEsq"].ToString(), Convert.ToInt32(linha["diagonal"]), Convert.ToInt32(linha["horizontal"]), Convert.ToInt32(linha["nivelLongarina"]), linha["t"].ToString(), linha["riscoLongEsq"].ToString(), Convert.ToInt32(linha["travaSeguranca"]), linha["observacaoEsq"].ToString(), Convert.ToInt32(linha["nota"]));
                    Localizacao localizacao = new Localizacao(Convert.ToInt32(linha["codigo"]));
                    localizacoes.Add(localizacao);
                }

                return localizacoes;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
