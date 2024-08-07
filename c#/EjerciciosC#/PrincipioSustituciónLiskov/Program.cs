using System;

namespace LiskovSubstitutionPrinciple
{
    // Clase base
    public class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // Clase derivada
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra.");
        }
    }

    // Clase derivada
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla.");
        }
    }

    class Program
    {
        static void HacerSonidoDelAnimal(Animal animal)
        {
            animal.HacerSonido();
        }

        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();

            HacerSonidoDelAnimal(perro); 
            HacerSonidoDelAnimal(gato);  
        }
    }
}
