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

            int marcaDigitos = marca.Length;
            int nombreDigitos=nombre.Length;
            int tipoDigitos = tipo.Length;

       

            papitas papitas = new papitas(marca,nombre,tipo,peso);
            StreamWriter sw = new StreamWriter ("Papitas.txt",true);
            //si el archivo no existe creara el documento
            //si ya existe escribira en el 
            //true es para agregar y sobreescribir 
            
            //Primera palabra de la lista
            if (marcaDigitos < 8)
            {
                sw.Write(papitas.marca+"\t\t");

                //Segunda papabra de la lista
                if (nombreDigitos < 8) 
                {
                    sw.Write(papitas.nombre + "\t\t");

                    //Tercera palabra de la lista
                    if (tipoDigitos < 8)
                    {
                        sw.Write(papitas.tipo + "\t\t");
                    }
                    else if (tipoDigitos >= 8 && tipoDigitos < 16)
                    {
                        sw.Write(papitas.tipo + "\t");
                    }

                }
                //segunda palabra
                else if (nombreDigitos >= 8 && nombreDigitos < 16) 
                {
                    sw.Write(papitas.nombre + "\t");

                    //Tercera palabra de la lista
                    if (tipoDigitos < 8)
                    {
                        sw.Write(papitas.tipo + "\t\t");
                    }
                    else if (tipoDigitos >= 8 && tipoDigitos < 16)
                    {
                        sw.Write(papitas.tipo + "\t");
                    }
                }

                //Cuarte palabra 
                sw.Write(papitas.Peso + "g\r\n");
            }
            else
            //segunda opcion primera palabra
            if (marcaDigitos >= 8 && marcaDigitos<16)
            {
                sw.Write(papitas.marca + "\t");

                //Segunda papabra de la lista
                if (nombreDigitos < 8)
                {
                    sw.Write(papitas.nombre + "\t\t");

                    //Tercera palabra de la lista
                    if (tipoDigitos < 8)
                    {
                        sw.Write(papitas.tipo + "\t\t");
                    }
                    else if (tipoDigitos >= 8 && tipoDigitos < 16)
                    {
                        sw.Write(papitas.tipo + "\t");
                    }

                }
                //segunda palabra de la lista
                else if (nombreDigitos >= 8 && nombreDigitos < 16)
                {
                    sw.Write(papitas.nombre + "\t");

                    //Tercera palabra de la lista
                    if (tipoDigitos < 8)
                    {
                        sw.Write(papitas.tipo + "\t\t");
                    }
                    else if (tipoDigitos >= 8 && tipoDigitos < 16)
                    {
                        sw.Write(papitas.tipo + "\t");
                    }

                }

                //cuarta palabra
                sw.Write(papitas.Peso+"g\r\n");

            }

            sw.Close();
            Console.WriteLine("archivo guardado");
            Console.ReadKey();
        }
    }
}
