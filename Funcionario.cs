using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativa
{
    class Funcionario : Pessoa
    {
        private int cargo;
        private int numeroMatrica;
        private double salarioBase;
        private double horaExtra;
        private double salarioBruto;
        private string cpf;
        private double salarioliquido;


        public double SalarioLiquido
        {
            get
            {
                return salarioliquido;
            }
            set
            {
                salarioliquido = value;
            }
        }


        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public int Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value;
            }
        }


        public int Matricula
        {
            get
            {
                return numeroMatrica;
            }
            set
            {
                numeroMatrica = value;
            }
        }

        public double SalarioBase
        {
            get
            {
                return salarioBase;
            }
            set
            {
                salarioBase = value;
            }
        }


        public double HoraExtra
        {
            get
            {
                return horaExtra;
            }
            set
            {
                horaExtra = value;
            }
        }
        public double SalarioBruto
        {

            get
            {
                return salarioBruto;
            }
            set
            {
                salarioBruto = value;
            }
        }



        //METODOS VIRTUAIS

        public virtual double CalculoSalarioBruto()
        {
            return 0;
        }

        public string RelacaoDados()
        {
            string msg;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            msg = "Nome: " + Nome + "|| Endereço: " + Endereco + "|| Cargo: " + Cargo + "|| CPF: " + Cpf + "||Salário Liquido: " + CalculoSalarioBruto();
            Console.ForegroundColor = ConsoleColor.White;
            return msg;

        }

    }
}