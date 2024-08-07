using System;

namespace InterfaceSegregationPrinciple
{
    // Interfaces pequeñas y específicas para diferentes tipos de saludos
    public interface ISaludoFormal
    {
        void SaludarFormalmente();
    }

    public interface ISaludoInformal
    {
        void SaludarInformalmente();
    }

    // Implementación de saludo formal
    public class SaludoFormal : ISaludoFormal
    {
        public void SaludarFormalmente()
        {
            Console.WriteLine("Buenos días, ¿cómo está usted?");
        }
    }

    // Implementación de saludo informal
    public class SaludoInformal : ISaludoInformal
    {
        public void SaludarInformalmente()
        {
            Console.WriteLine("¡Hola, cómo estás!");
        }
    }

    // Clase que usa interfaces específicas para saludos
    public class Persona
    {
        private readonly ISaludoFormal _saludoFormal;
        private readonly ISaludoInformal _saludoInformal;

        public Persona(ISaludoFormal saludoFormal, ISaludoInformal saludoInformal)
        {
            _saludoFormal = saludoFormal;
            _saludoInformal = saludoInformal;
        }

        public void SaludarFormal()
        {
            _saludoFormal.SaludarFormalmente();
        }

        public void SaludarInformal()
        {
            _saludoInformal.SaludarInformalmente();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISaludoFormal saludoFormal = new SaludoFormal();
            ISaludoInformal saludoInformal = new SaludoInformal();
            Persona persona = new Persona(saludoFormal, saludoInformal);

            persona.SaludarFormal();    // Salida: Buenos días, ¿cómo está usted?
            persona.SaludarInformal();  // Salida: ¡Hola, cómo estás!
        }
    }
}
