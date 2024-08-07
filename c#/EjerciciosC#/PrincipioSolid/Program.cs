using System;

namespace ConSRP
{
    // Clase responsable de los datos del empleado
    public class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
    }

    // Clase responsable de mostrar información del empleado
    public class EmpleadoImpresora
    {
        public void ImprimirInformacion(Empleado empleado)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado
            {
                Nombre = "Juan Pérez",
                Salario = 50000
            };

            EmpleadoImpresora impresora = new EmpleadoImpresora();
            impresora.ImprimirInformacion(empleado); // Imprime los detalles del empleado
        }
    }
}
