﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Localizacao(int codigo, DateTime dataEspecionamento, string rua, int numeroLinha, string colEsq, string riscoColEsq, int diagonal, int horizontal, int nivelLongarina, string t, string riscoLongEsq, int travaSeguranca, string observacaoEsq)
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
        }

        public Localizacao()
        {

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

    }
}
