using System;

namespace EjemploHerencia
{
   
    public abstract class Animal
    {
        
        public abstract void HacerSonido();

        
        public void Respirar()
        {
            Console.WriteLine("El animal está respirando.");
        }
    }

    public class Perro : Animal
    {
      
        public override void HacerSonido()
        {
            Console.WriteLine("El perro hace: Guau Guau!");
        }
    }

 
    public class Gato : Animal
    {
  
        public override void HacerSonido()
        {
            Console.WriteLine("El gato hace: Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Animal miPerro = new Perro();
            miPerro.HacerSonido();
            miPerro.Respirar();

           
            Animal miGato = new Gato();
            miGato.HacerSonido();
            miGato.Respirar();
        }
    }
}
