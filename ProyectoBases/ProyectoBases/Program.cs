using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] especie = {"Perro", "Gato" };
            string[] raza = {"Chihuahua", "P.Aleman", "Husky", "Boxer", "Labrador", "Pug", "Chow Chow"  };
            string[] gatos = { "Azul Ruso", "Persa", "Siames", "Ragdoll", "Sphynx", "Burmes", "Bengala" };
            string[] colorPelo = {"Cafe", "Negro", "Beige", "Blanco", "Gris", "Mixto", "Chocolate" , "Arena"  };
            string[] enfermedades = {"Dirofilaria", "Leishmaiosis", "Parvovirus", "Rabia", "Moquillo", "Artrosis", "Prob.Orina", "Digestion", "Otitis" };
            string[] eGatos = {"Leucemia felina", "Peritonitis", "Otitis", "Rabia", "Panleucopenia", "Conjuntivitis" };
            string[] pruebas = {"Orina", "Heces", "Mucosa Oral", "Rayos X", "Tomografia", "Resonancia" };
            string[] clinias = { "Gutierrez", "Mccullough", "Heath", "Singleton", "Kelley", "Freeman", "Thornton", "Franks", "Stafford", "Randall" };
            string[] medicina = {"Antiparasitos", "Vitaminas", "Calcio", "Antihistaminico", "Jabon Especial", "Shampoo", "Antitusivo" } ;
            string[] duracion = {"1 semana", "3 dias", "1 mes", "7 dias", "2 semanas" };
            string[] dosificacion = {"1 pastilla en la noche", "Masajes por las mañanas", "Antibiotico en la mañana, Antitusivo por la tarde", "1 pastilla cada 6 horas" };
            string[] sintomas = {"Vomito", "Decaido", "Diarrea", "Poco apetito", "Problemas piel", "Herida" };
            string[] producto = {"Karngan", "Acetaminofen", "Endogard", "Analgin", "Fattisal", "Erkon", "Procox", "Tranquilan", "Advocate", "Parasitin", "Telmin", "Enroxtal" };
            Random rnd = new Random();
            int aleatorio = rnd.Next(2);
            int aleatorio2 = rnd.Next(9);
            int aleatorio3 = rnd.Next(pruebas.Length);

            for (int i = 0; i < 49; i++)
            {
                    Console.WriteLine(pruebas[aleatorio3]);                                                        
                    aleatorio3 = rnd.Next(pruebas.Length );
            }
            Console.ReadLine();
        }
    }
}
