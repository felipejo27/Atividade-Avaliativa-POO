using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativa
{
    class Pessoa
    {
        private int ano;
        private string nome;
        private string endereco;
        private int idade;


        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }



        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }
        public bool Senador()
        {
            if ((2018 - Ano) < 35)
            {
                return false;
            }
            return true;
        }


    }
}