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
            StreamWriter sw = new StreamWriter ("ejemplo.txt",true);
            //si el archivo no existe creara el documento
            //si ya existe escribira en el 
            //true es para agregar y sobreescribir 
            
            
            string[] lineas =  new string[3];
       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("escribe un nombre");
                lineas[i]=Console.ReadLine();
            }
            //Recorre el arreglo 
            foreach (string line in lineas)
            {
                sw.WriteLine(line);
            }
            sw.Close();
            Console.WriteLine("archivo guardado");
            Console.ReadKey();
        }
    }
}
