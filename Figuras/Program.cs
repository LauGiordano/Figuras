using System;
using System.Collections;
using System.Collections.Generic;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 1. Cualculadora
             * 2. Creacion de Rectangulos / Cuadrados /Triangulos /Redondeles
             * 2.A Que de la superficie y el Perimetro
             * 2.B Que de el nombre del tipo de objeto
             * 3. Crear una fabrica de Objetos figuras que en base a un random
             * me devuelve una figura al azar. Luego procesar todos esos objetos
             * dando el nombre de cada uno y su superficie y su permitro
             * */
            
            Fabrica fabrica = new Fabrica();
            fabrica.mostrarLista();
            Console.ReadKey();
        }
    }
}