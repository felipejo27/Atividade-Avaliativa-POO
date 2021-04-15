using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativa
{
    class Professores : Funcionario
    {
        public Professores(int c, int m, string n, string e, double s, string cp, double h)
        {
            Cargo = c;
            Matricula = m;
            Nome = n;
            Endereco = e;
            SalarioBase = s;
            Cpf = cp;
            HoraExtra = h;

        }
        public override double CalculoSalarioBruto()
        {

            //GRATIFICAÇÃO EXTRA CLASSE
            SalarioBruto = (SalarioBase * 70) + ((SalarioBase * 70) * 0.25);

            //TESTE PARA VER SE É MESTRE
            if (Cargo == 2)
            {
                SalarioBruto = SalarioBruto + +((SalarioBase * 70) * 0.25);
            }

            //TESTE PARA VER SE É DOUTOR
            if (Cargo == 3)
            {
                SalarioBruto = SalarioBruto + +((SalarioBase * 70) * 0.35);
            }


            //Deduções do INSS
            if (SalarioBruto > 30000)
            {
                SalarioLiquido = SalarioBruto - 3000;
            }
            else
            {
                SalarioLiquido = SalarioBruto - (SalarioBruto * 0.11);
            }

            //Deduções do IPRF
            if (SalarioLiquido > 4000)
            {
                SalarioLiquido = SalarioLiquido - (SalarioLiquido * 0.25);
            }
            // inss é de 5% com desconto até 400 reais 
            return SalarioLiquido;


        }

    }
}