using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string marca = null, nombre = null, tipo = null;
            int peso=0;

          

                Console.Write("escribe una marca de papas: ");
                marca = Console.ReadLine();
                Console.Write("Escribe el nombre de las papas: ");
                nombre = Console.ReadLine();
                Console.Write("Escribe el tipo de las papitas: ");
                tipo = Console.ReadLine();
                Console.Write("Escribe el peso de las papas: ");
                peso = Int32.Parse(Console.ReadLine());

            

            papitas papitas = new papitas(marca,nombre,tipo,peso);
            StreamWriter sw = new StreamWriter ("Papitas.txt",true);
            //si el archivo no existe creara el documento
            //si ya existe escribira en el 
            //true es para agregar y sobreescribir 





           
              sw.WriteLine(papitas.marca + "\t\t" + papitas.nombre  + "\t\t" + papitas.tipo + "\t\t" + papitas.Peso);
            
            sw.Close();
            Console.WriteLine("archivo guardado");
            Console.ReadKey();
        }
    }
}
