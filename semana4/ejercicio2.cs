using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class ejercicio2
    {

        public static void Main(string[] args) 
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Sumar(10, 20);
            calculadora.Sumar3(10, 20, 30);
            calculadora.SumarString("hola", 10, 20);
            calculadora.EsParONo(2320);
        }

        class Calculadora() 
        {
            
            
            public int Sumar(int a, int b)
            {
                Console.WriteLine(a+b);
                return a + b;
            }

            public double Sumar3(double a, double b, double c)
            {
                Console.WriteLine(a + b + c);
                return a + b + c;
            }


            public void SumarString(string mensaje, int a,  int b) 
            {
                Console.Write(mensaje);
                Console.WriteLine(a+b);
            }

            public bool EsParONo(int a) 
            {   
              
                if (a % 2 == 0)
                {
                    Console.WriteLine("es par");
                    return true;
                }
                else {
                    Console.WriteLine("es impar");
                    return false;
                    
                }
            }
        }
    }
}



/*
 Crear una clase Calculadora.

Crear un método sumar(int a, int b) que devuelva una suma.
Crear un método sumar(double a, double b, double c) para sumar tres números.
Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).
Saludos! Buen martes.
 */