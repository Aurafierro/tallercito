using System;

namespace DependencyInversionPrinciple
{
    
    public interface IColor
    {
        void AplicarColor();
    }

    
    public class ColorRojo : IColor
    {
        public void AplicarColor()
        {
            Console.WriteLine("Aplicando color rojo.");
        }
    }

    public class ColorAzul : IColor
    {
        public void AplicarColor()
        {
            Console.WriteLine("Aplicando color azul.");
        }
    }

    public class Objeto
    {
        private readonly IColor _color;

        public Objeto(IColor color)
        {
            _color = color;
        }

        public void AplicarColor()
        {
            _color.AplicarColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            IColor colorRojo = new ColorRojo();
            Objeto objetoRojo = new Objeto(colorRojo);
            objetoRojo.AplicarColor(); // Aplicando color rojo.

            IColor colorAzul = new ColorAzul();
            Objeto objetoAzul = new Objeto(colorAzul);
            objetoAzul.AplicarColor(); // Aplicando color azul.
        }
    }
}
