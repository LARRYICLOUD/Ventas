using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged =matriz de matrices


            /*Tipo[][] nombre= new tipo[filas][]
            double[][] ventas = new double[4][3]
            {
                new double[] {155,100,170},
                new double[] {205,120},
                new double[] {115,190,104,130},
                new double[] {163,218,125}

            };*/
            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR  EN C# Y EXPERTO EN REDES EXCELENTE");

            //
            //Mostramos cuantos elementos tiene la matriz con la propiedad length
            //Console.WriteLine(numeros.Length );
            double[][] ventas = new double[4 ][]  
            {  
                
              new double[]  { 18, 25, 6 },
              new double[] { 19, 28  },
              new double [] { 15, 45, 66,99 },
              new double []  { 15, 45, 66 } 
            };

            Console.WriteLine(ventas[0].Length);
            Console.WriteLine(ventas[1].Length);
            Console.WriteLine(ventas[2].Length);
            Console.WriteLine(ventas[3].Length);

        }
    }




}
