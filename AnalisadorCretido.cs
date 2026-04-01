using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AnalisadorCredito
    {
        public int Calcular(ContaBancaria conta)
        {
            int score = 1000;

            string estado = conta.Titular.EstadoUF.ToUpper();
            string nome = conta.Titular.Nome.Trim();

           
            if (conta.Saldo > 5000)
            {
                score += 100;
            }

           
            if (conta.Saldo < 0)
            {
                score -= 200;
            }

           
            if (estado == "SE")
            {
                score += 150;
            }

           
            if (nome.Length < 5)
            {
                score -= 50;
            }

           
            if (conta.Saldo == 0)
            {
                score -= 100;
            }

            if (estado == "RJ" || estado == "SP")
            {
                score -= 40;
            }

            if (conta.Saldo > 100000)
            {
                score += 300;
            }

            
            if (estado == "SC")
            {
                score += 100;
            }

           
            if (estado == "BA" || estado == "PE" || estado == "AL" ||
                estado == "CE" || estado == "MA" || estado == "PB" ||
                estado == "PI" || estado == "RN" || estado == "SE")
            {
                score += 40;
            }

            
            if (conta.Saldo >= 1 && conta.Saldo <= 500)
            {
                score += 10;
            }

            return score;
        }
    }
}
