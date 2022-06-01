using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraArchivos
{
    class papitas
    {
        public string marca,nombre,tipo;
        private int peso;

        public papitas(string marca,string nombre, string tipo,int peso)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.tipo = tipo;
            this.Peso = peso;
        }
        public int Peso
        {
            get { return peso; }
            set 
            {
                if (value <= 340)
                {
                    peso = value;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Peso de las papas inexistente");
                    Console.Write("Escribe el peso de las papas: ");
                    peso = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
  
}
