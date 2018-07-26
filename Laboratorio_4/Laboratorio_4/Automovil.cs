using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Automovil
    {
        private int modelo = 2010;
        private double precio = 10000;
        private string marca = "";
        private bool disponible = false;
        private double tipoCambioDolar = 7.75;
        private double descuentoAplicado = 0;

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unaMarca)
        {
            marca = unaMarca;
        }

        public void DefinirTipoCambio(double unTipoCambio)
        {
            tipoCambioDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad()
        {
            if (disponible)
            {
                disponible = false;
            }
            else
            {
                disponible = true; 
            }
        }

        public string MostrarDisponibilidad()
        {
            if (disponible)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponible actualmente";
            }
        }

        public string MostrarInformacio()
        {
            return "DATOS DEL AUTOMOVIL:\n" + "Marca: " + marca + "\n"
                                            + "Modelo: " + modelo + "\n"
                                            + "Precio de venta: Q" + precio + "\n"
                                            + MostrarDisponibilidad();
        }

        public double AplicarDescuento(double miDescuento)
        {
            descuentoAplicado = miDescuento;
            precio -= descuentoAplicado;
            DefinirPrecio(precio);
            return precio; 
        }
    }
}
