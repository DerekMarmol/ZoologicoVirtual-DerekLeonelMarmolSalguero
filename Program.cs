using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al zoologico Virtual, tenemos una amplia variedad de animales con los cuales puedes interactuar y divertirte.");

            List<Animal> animales = new List<Animal>();
            animales.Add(new Animal("León", "Masculino", "Rugido", "Carne"));
            animales.Add(new Animal("Elefante", "Femenino", "Barreo", "Hierbas"));
            animales.Add(new Animal("Jirafa", "Masculino", "Ronquido", "Hojas"));
            animales.Add(new Animal("Tigre", "Femenino", "Rugido", "Carne"));
            animales.Add(new Animal("Mono", "Masculino", "Chillido", "Frutas"));
            animales.Add(new Animal("Oso", "Femenino", "Gruñido", "Peces"));
            animales.Add(new Animal("Cocodrilo", "Masculino", "Siseo", "Carnes"));
            animales.Add(new Animal("Serpiente", "Femenino", "silbido", "roedores"));
            animales.Add(new Animal("Pinguino", "Masculino", "Grazneo", "Peces"));
            animales.Add(new Animal("Lobo", "Femenino", "Aullido", "Carne"));
            animales.Add(new Animal("Cebra", "Masculino", "Relincheo", "Pasto"));
            animales.Add(new Animal("Rinoceronte", "Femenino", "Barrido", "Hierbas"));
            animales.Add(new Animal("Panda", "Masculino", "Chillido", "Bambu"));
            animales.Add(new Animal("Pavo Real", "Femenino", "Gugluteo", "Hojas"));
            animales.Add(new Animal("Tortuga", "Masculino", "Gruñido", "Algas"));


           do
            {
                Console.WriteLine("Animales disponibles:");
                for (int animal = 0; animal < animales.Count; animal++)
                {
                    Console.WriteLine((animal + 1) + ". " + animales[animal].Nombre);
                }

                int seleccion;
                Animal animalSeleccionado = null;

                do
                {
                    Console.WriteLine("Seleccione el número del animal con el que desea interactuar:");
                    seleccion = int.Parse(Console.ReadLine()) - 1; 


                    if (seleccion >= 0 && seleccion < animales.Count)
                    {
                        animalSeleccionado = animales[seleccion];
                        Console.WriteLine();
                        Console.WriteLine("Ha seleccionado al " + animalSeleccionado.Nombre);
                    }
                    else
                    {
                        Console.WriteLine("Selección no válida. Por favor, elija un número de animal válido.");
                    }
                } while (seleccion < 0 || seleccion >= animales.Count);


                int opcion;
                do
                {
                    Console.WriteLine(); 

                    Console.WriteLine("¿Qué acción deseas realizar con el " + animalSeleccionado.Nombre + "?");
                    Console.WriteLine("1. Hacer que coma");
                    Console.WriteLine("2. Hacer que se mueva");
                    Console.WriteLine("3. Hacer que haga un sonido");
                    Console.WriteLine("4. Seleccionar otro animal");
                    Console.WriteLine("5. Salir del zoológico");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine();
                            animalSeleccionado.Comida();
                            break;
                        case 2:
                            Console.WriteLine();
                            animalSeleccionado.Mover();
                            break;
                        case 3:
                            Console.WriteLine();
                            animalSeleccionado.Sonido();
                            break;
                        case 4:
                            break; 
                        case 5:
                            Console.WriteLine("Gracias por visitar el zoológico. ¡Hasta luego!");
                            Console.Read();
                            return; 
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                } while (opcion != 4);
                
            } while (true);

        }
        
    }
}
