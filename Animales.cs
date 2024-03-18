using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Animal
    {
        private string nombre;
        private string sexo;
        private string rugido;
        private string comer;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Animal(string nombre, string sexo, string rugido, string comer)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.rugido = rugido;
            this.comer = comer;
        }

        public void Comida()
        {
            Console.WriteLine(nombre + " ha comido " + comer);
        }

        public void Mover()
        {
            Console.WriteLine(nombre + " se ha movido");
        }

        public void Sonido()
        {
            Console.WriteLine("El sonido de " + nombre + " es un " + rugido);
        }

    }
}
