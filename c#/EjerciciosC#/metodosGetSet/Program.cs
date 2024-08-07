using System;

namespace EjemploCalculadoraSimple
{
    public class Calculadora
    {
        private int numero1;
        private int numero2;

        // Propiedad para obtener y establecer numero1
        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; } // Sin validación adicional para simplificar
        }

        // Propiedad para obtener y establecer numero2
        public int Numero2
        {
            get { return numero2; }
            set { numero2 = value; } // Sin validación adicional para simplificar
        }

        // Método para sumar
        public int Sumar()
        {
            return Numero1 + Numero2;
        }

        // Método para restar
        public int Restar()
        {
            return Numero1 - Numero2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Calculadora calculadora = new Calculadora();

            calculadora.Numero1 = 10;
            calculadora.Numero2 = 5;

          
            Console.WriteLine($"Suma: {calculadora.Sumar()}"); 
            Console.WriteLine($"Resta: {calculadora.Restar()}"); 
        }
    }
}
