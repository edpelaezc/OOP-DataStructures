using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaDeTrabajo1
{
    class Cajero
    {
        public int tiempo = 0;
        public float clientesAtendidos = 0;
        public float tiempoAcumulado = 0;                

        public void tiempoAtencion(int n)
        {
            tiempo = n;            
            tiempoAcumulado += tiempo;
        }

        public void atender()
        {
            clientesAtendidos++;
        }
    }
}
