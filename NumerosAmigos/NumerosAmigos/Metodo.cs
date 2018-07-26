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
    }
}
