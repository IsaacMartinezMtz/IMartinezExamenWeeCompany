using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Areglos();

            Console.WriteLine("******************");
            //ComprimirCadema();
            //Console.WriteLine("********************");
            OrdenarLista();
            //Console.WriteLine("**************************");
            //int baseL = 4;
            //int height = 10;
            //Console.WriteLine(CalculateTriangleArea(baseL, height));

            //int baseNumber = 2, exponent = 5;
            //Console.WriteLine(Exponencial(baseNumber, exponent));


            Console.ReadKey();

        
        }

        public static void Areglos()
        {
            bool respuesta = false;
            
            int numero =0;

            //Matriz
            int[,] matriz = new int[3, 3]
            {
                {1, 3, 5 },
                {7,9, 11 },
                {13,15,17 }
            };
            Console.WriteLine("Ingresa el numero a buscar en la matriz");
            numero = int.Parse(Console.ReadLine());
            // recorrer matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Evalua la matriz si el contenido en esa posicion es igaul al numero ingresado
                    if (matriz[i,j] == numero)
                    {
                        respuesta = true;
                    }  
                }
            }
            Console.WriteLine(respuesta);
        }
        public static void ComprimirCadema()
        {
            Console.WriteLine("Ingresa la caena a comprimir");
            string cadena= Console.ReadLine();
           
            //Creamos una variable modificable en el proceso
            var resultado = new StringBuilder();
            //Almacena la cadena pero convertidad a cosigo Ascci
            char caracterActual = cadena[0];
            // Contador 
            int conteo = 1;
            //ciclo para recorrer las cadena por cada uno de sus elementos 
            for (int i = 1; i < cadena.Length; i++)
            {
                //Evalua lo que tienen en la posicion en la cadena se encuntra en caracter actual lo va sumando al contador  
                if (cadena[i] == caracterActual)
                {
                    conteo++;
                }
                else
                {
                    //Cuando ya no encuntra mas caracterares lo guarda en resultado 
                    resultado.Append(caracterActual);
                    resultado.Append(conteo);
                    caracterActual = cadena[i];
                    conteo = 1;
                }
            }

            resultado.Append(caracterActual);
            resultado.Append(conteo);

            Console.WriteLine( resultado.ToString());
        }
        public static void OrdenarLista()
        {
            //Creamos la lista y le asignamos valores
            List<string> frutas = new List<string> { "Apple", "banana", "grape", "Orange", "apple", "Grape" };
            //Metodo Sor ordena la lista 
            //a,b Son elementos de la lista que se estan comparando 
            // en la comparacion perzonalizada envia las lisca ordenada tomando en cuenta las letras mayusculas y minusculas 
            frutas.Sort((a, b) => string.Compare(a, b, StringComparison.Ordinal));

            //Recorre la lista ordenada 
            foreach (var fruta in frutas)
            {
                //Imprime los elementos de la cadena 
                Console.WriteLine( fruta);
            }
        }
        public static double CalculateTriangleArea(int baseL , int height)
        {
            double area = baseL * height / 2;
            return area;
        }
        public static int Exponencial(int baseNumber, int exponent)
        {
            int result = 0;
            for(int i = 0; i <= exponent; i++){
                result += baseNumber;
            }
            return result;
        }





    }
}