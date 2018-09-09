using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial1PA
{
    class MetodosRecursivos
    {
        string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Stack<string> myStack = new Stack<string>();

        public int sumaElementos(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + sumaElementos(n - 1);
            }
        }

        public int maximoComunDivisor(int a, int b)
        {
            if (a > b)
            {
                return maximoComunDivisor(a - b, b);
            }
            else if (b > a)
            {
                return maximoComunDivisor(a, b - a);
            }
            else if (b == 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int duplicacionRuso(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                if (a % 2 != 0)
                {
                    return b + duplicacionRuso(a / 2, b * 2);
                }
                else
                {
                    return duplicacionRuso(a / 2, b * 2);
                }
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Devuelve el resultado fina
        public string cambioBase(string n, int baseFuente, int baseDestino)
        {
            string result = "";
            if (validacion(n, baseFuente))
            {
                cambio(baseDestino, cambioDecimal(baseFuente, n));
                for (int i = 0; i < n.Length - 1; i++)
                {
                    result += myStack.Pop();
                }
                return result;
            }
            else
            {
                return "NO ES POSIBLE REALIZAR LA CONVERSIÓN ENTRE LOS NÚMEROS.";
            }
        } 

        //Valida que el numero sea correcto en la base fuente proporcionada por el usuario
        public bool validacion(string n, int baseFuente)
        {
            int i = 0;
            bool flag = true;
            while (flag && i < n.Length)
            {
                if (int.Parse(n[i].ToString()) < baseFuente)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                i++;
            }
            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Cambia el numero "n" proporcionado por el usuario a base decimal, para luego convertirlo a la base destino
        public int cambioDecimal(int baseFuente, string n)
        {
            if (baseFuente == 10)
            {                
                return int.Parse(n);
            }
            else
            {
                double result = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    result += int.Parse(n[i].ToString()) * Math.Pow(baseFuente, (n.Length - i - 1));
                }
                return int.Parse(result.ToString());
            }
        }

        //Realiza el cambio de base decimal a la base destino en base al alfabeto creado arriba.
        public void cambio(int baseDestino, int n)
        {
            if (baseDestino < n / baseDestino)
            {
                myStack.Push((alphabet[(n % baseDestino)].ToString()));
                cambio(baseDestino, n / baseDestino);
            }
            else
            {
                myStack.Push((alphabet[n % baseDestino].ToString()));
                myStack.Push((alphabet[n / baseDestino].ToString()));
            }
        }

        string invertirCadena(string cadena)
        {
            if (cadena.Length == 1)
            {
                return cadena;
            }
            else
            {
                return invertirCadena(cadena.Substring(1)) + cadena[0];

            }
        }

        //verificar si una palabra es palindroma con mi función para invertir una cadena
        /*public bool esPalindromo(string cadena)
        {
            if (cadena == invertirCadena(cadena))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        //funcion para ver si es palindroma de otra manera
        public bool esPalindromo(string cadena)
        {
            if (cadena.Length <= 1)
            {
                return true;
            }
            else
            {
                if (cadena[0] == cadena[cadena.Length - 1])
                {
                    return esPalindromo(cadena.Substring(1, cadena.Length - 2));
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
