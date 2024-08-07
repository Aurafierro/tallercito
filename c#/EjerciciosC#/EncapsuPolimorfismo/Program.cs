using System;

namespace EjercicioEncapsulamientoPolimorfismo
{
    public abstract class Saludo
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Saludo(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void Saludar();

        // Sobrecarga de métodos Saludar
        public void Saludar(string saludoAdicional)
        {
            Console.WriteLine($"{saludoAdicional}, {Nombre}!");
        }
    }

    public class SaludoFormal : Saludo
    {
        public SaludoFormal(string nombre) : base(nombre) { }

        public override void Saludar()
        {
            Console.WriteLine($"Buenos días, Sr./Sra. {Nombre}.");
        }
    }

    public class SaludoInformal : Saludo
    {
        public SaludoInformal(string nombre) : base(nombre) { }

        public override void Saludar()
        {
            Console.WriteLine($"¡Hola, {Nombre}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Saludo saludoFormal = new SaludoFormal("González");
            Saludo saludoInformal = new SaludoInformal("Carlos");

            saludoFormal.Saludar(); 
            saludoInformal.Saludar(); 

            saludoFormal.Saludar("Saludos"); 
            saludoInformal.Saludar("¡Qué tal!"); 
        }
    }
}
