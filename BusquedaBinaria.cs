using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosDeBusqueda_RLG
{
    internal class BusquedaBinaria
    {
        //Escribe un programa en C# que realice una búsqueda binaria para encontrar
        //un número en un arreglo de enteros ordenado de menor a mayor.
        //El programa debe solicitar al usuario un número a buscar y luego buscarlo
        //en el arreglo. Si el número se encuentra, debe imprimir su posición; de lo
        //contrario, debe indicar que el número no está en el arreglo.

        public void BuscarFormaBinario()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15 };
            Console.Write("Ingresa el número que deseas buscar: ");
            int numeroBuscado = int.Parse(Console.ReadLine());
            int posicion;
            int respuesta = 0;
            int bajo = 0;
            int superior = numeros.Length - 1;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    posicion = i;
                    Console.WriteLine($"La posicion del numero es: {posicion}");
                    
                }
            }
            while (bajo <= superior)
            {
                int medio = (bajo + superior) / 2;

                if (numeros[medio] == numeroBuscado)
                {
                    respuesta = 1;
                    break;
                }
                else if (numeroBuscado > numeros[medio])
                {
                    respuesta = 2;
                    superior = medio - 1;
                }
                
                else if (numeroBuscado < numeros[medio])
                {
                    respuesta = 3;
                    bajo = medio + 1;
                }
            }
            if (respuesta == 1)
            {
                Console.WriteLine("El número buscado está en la parte de en medio");
            }
            else if (respuesta == 2)
            {
                Console.WriteLine("El número buscado está en la parte superior");
            }
            else if (respuesta == 3)
            {
                Console.WriteLine("El número buscado está en la parte inferior");
            }
            else
            {
                Console.WriteLine($"El numero {numeroBuscado} no se encuentra en la matriz.");
            }

        }

        //

        public void BuscarCadenaBinaria()
        {
            string[] frutas = { "Fresa","Mandarina","Mango","Manzana",
                "Melon",
                "Naranja", "Pera", 
                "Platano", "Uva"};
            Console.Write("Ingresa el nombre de la fruta que buscas: ");
            string frutaBuscado = Console.ReadLine();
            int posicion;
            int respuesta = -2;
            int bajo = 0;
            int superior = frutas.Length - 1;
            int posicionGlobal = 0;
            for (int i = 0; i < frutas.Length; i++)
            {
                if (frutas[i] == frutaBuscado)
                {
                    posicion = i;
                    Console.WriteLine($"La posicion de la fruta {frutaBuscado} es: {posicion}");
                    respuesta += 0;
                    posicionGlobal += i;
                }
            }
            for (int i = 0; i < frutas.Length; i++)
            {
                int medio = (bajo + superior) / 2;
                int comparacion = string.Compare(frutas[medio], frutaBuscado, StringComparison.Ordinal);
                if (comparacion == 0)
                {
                    Console.WriteLine("La fruta buscada esta en la parte de en medio");
                    respuesta = 1;
                    i = frutas.Length + 1;//detener ejecucion del ciclo
                }
                else if (comparacion > 0)
                {
                    Console.WriteLine("El numero buscado esta en la parde de bajo");
                    respuesta = 1;
                    i = frutas.Length + 1;//detener ejecucion del ciclo
                }
                else if (!(frutas[i]==frutaBuscado) && comparacion !< 0)
                {
                    respuesta -= 1;
                }
                else if (comparacion < 0)
                {
                    Console.WriteLine("La fruta buscada esta en la parte superior");
                    respuesta = 1;
                    i = frutas.Length + 1;//detener ejecucion del ciclo
                }
                
            }
            if (respuesta < 0)
            {
                Console.WriteLine($"El animal {frutaBuscado} no se encuentra en la matriz.");
            }
        }

        //ultimo

       public void BuscarPrimerParBini()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 11,   13   ,    15   ,    16   , 19, 21, 23, 25, 27, 29 };

            int primerNumeroPar = 0;
            int respuesta = -1;

            // Encuentra el primer número par en el arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    primerNumeroPar = numeros[i];
                    respuesta = 0;
                    break;
                }
            }

            if (respuesta == 0)
            {
                int bajo = 0;
                int superior = numeros.Length - 1;

                while (bajo <= superior)
                {
                    int medio = (bajo + superior) / 2;

                    if (numeros[medio] == primerNumeroPar)
                    {
                        respuesta = 1;
                        break; // El número par fue encontrado, salimos del bucle.
                    }
                    else if (primerNumeroPar > numeros[medio])
                    {
                        respuesta = 2;
                        superior = medio - 1; // El número par está en la mitad superior.
                    }
                    else
                    {
                        respuesta = 3;
                        bajo = medio + 1; // El número par está en la mitad inferior.
                    }
                }
            }

            if (respuesta == 1)
            {
                Console.WriteLine("El número buscado está en la parte de en medio");
            }
            else if (respuesta == 2)
            {
                Console.WriteLine("El número buscado está en la parte superior");
            }
            else if (respuesta == 3)
            {
                Console.WriteLine("El número buscado está en la parte inferior");
            }
            else
            {
                Console.WriteLine("No se encontró un número par en la matriz.");
            }
       }

    }
}
