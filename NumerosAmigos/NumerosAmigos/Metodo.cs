using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAmigos
{
    class Metodo
    {
        public int SumaDivisores(int n)
        {
            int divisores = 0;
            for (int i = 1; i < n; i++)
            {
                if (n%i == 0)
                {
                    divisores += i;
                }
                else
                {                    
                }
            }
            return divisores; 
        }

        public bool Comparacion(int n, int m)
        {
            if (SumaDivisores(n) == m && SumaDivisores(m) == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string numerosPrimos()
        {
            int numeroDivisores = 0;
            int contador = 1;
            string primos = "";
            for (int i = 1; i < 50; i++)
            {
                for (int j = 1; j < contador; j++)
                {
                    if (contador % j == 0)
                    {
                        numeroDivisores++;
                    }
                }
                if (numeroDivisores > 1)
                {
                    primos += contador.ToString() + ",";
                }
                contador++;
            }

            return primos;
        }
    }
}
