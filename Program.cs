using System;

namespace CalculadoraGrupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Grupal UPN");

            Console.WriteLine("Ingresa el primer numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            double n2 =  double.Parse(Console.ReadLine());

            Console.WriteLine("Resultados");
            Console.WriteLine("Suma: "+ Sumar(n1,n2));
            Console.WriteLine("Resta: " + Restar(n1, n2));
            Console.WriteLine("Division: " + division(n1,n2)); 
            Console.WriteLine("Multiplicar: "+ multiplicacion(n1,n2));        
            Console.WriteLine("Modulo: "+ modulo(n1,n2));
            Console.WriteLine("AlCuadrado: " + elevaralcuadrado(n1)); 
        }

        static double Sumar(double a, double b)
        {
            return a + b ;
        } 

         static double multiplicacion(double a, double b)
        {
            return a*b ;
            
        }

            static double Restar(double a, double b)
        {
            return a - b;
        }
 
        static double division( double a, double b)
            {
            return a/b; 
            }


            static double modulo(double a, double b)
            {
                return a % b;
            }
        
            static double elevaralcuadrado(double a)
        {
                return a*a;
        }
}
}