using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosDeBusqueda_RLG
{
    internal class BusquedaLineal
    {
        public void listaEnteros()
        {
            //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número en una lista de enteros.
            //El programa debe pedir al usuario un número a buscar y luego buscarlo en la matriz. Si el número está en la matriz,
            //el programa debe imprimir su posición, de lo contrario, debe indicar que el número no se encuentra en la matriz.
            int[] numeros = { 1, 2, 3, 4, 5, 6, 122 };
            Console.Write("Ingresa el número que deseas buscar: ");
            int numeroBuscado = int.Parse(Console.ReadLine());
            int posicion;
            int respuesta = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    posicion = i;
                    Console.WriteLine($"La posicion del numero es: {posicion}");
                    respuesta += 1;
                }
            }
            if (respuesta == -1)
            {
                Console.WriteLine($"El numero {numeroBuscado} no se encuentra en la matriz.");
            }
        }
        //Crea un programa en C# que realice una búsqueda lineal para encontrar una cadena en un arreglo de cadenas.
        //El programa debe solicitar al usuario una cadena y buscarla en una matriz.
        //Si la cadena se encuentra en la matriz, se debe mostrar su índice; de lo contrario,
        //se debe indicar que la cadena no está presente.
        public void BuscarCadena()
        {
            string[] animales = { "Pulpo","Tejon","Ballena","Caballo","Perro","Gato","Abeja","Serpiente" };
            Console.Write("Ingresa el nombre de animal que buscas: ");
            string animalBuscado = Console.ReadLine();
            int posicion;
            int respuesta = -1;

            for (int i = 0; i < animales.Length; i++)
            {
                if (animales[i] == animalBuscado)
                {
                    posicion = i;
                    Console.WriteLine($"La posicion del animal {animalBuscado} buscado es: {posicion}");
                    respuesta += 1;
                }
            }
            if (respuesta == -1)
            {
                Console.WriteLine($"El animal {animalBuscado} no se encuentra en la matriz.");
            }
        }
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número par
        //en un arreglo de números enteros. El programa debe imprimir la primera posición
        //en la que se encuentra un número par en el arreglo.
        public void NumeroPar()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5, };
            int primerNumeroPar = 0;
            int posicion;
            for(int i=0;i < numeros.Length; i++)
            {
                if (primerNumeroPar==0 && numeros[i] != 0)
                {
                    if ((numeros[i] % 2) == 0)
                    {
                        posicion = i; 
                        Console.WriteLine($"La posicion del primer numero par encontrado es: {posicion}");
                        Console.WriteLine("Es el numero: " + numeros[i]);
                        primerNumeroPar -= 1;
                    }
                }
            }
        }
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar todos los
        //números pares en una matriz de números enteros. El programa debe imprimir todas las
        //posiciones en las que se encuentran los números pares en la matriz.
        public void TodosNumerosPares()
        {
            int[] numeros = { 2, 1, 2, 3, 4, 66,45 };
            int totalPares = 0;
            int posicion;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != 0)
                {
                    if ((numeros[i] % 2) == 0)
                    {
                        posicion = i;
                        Console.Write($"La posicion del numero par es: {posicion}, ");
                        Console.WriteLine("Es el numero: " + numeros[i]);
                        totalPares += 1;
                    }
                }
            }
            Console.WriteLine("El total de numeros pares fue: "+ totalPares);
        }
    }
}
