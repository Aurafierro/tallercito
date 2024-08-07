using System;

namespace SinOCP
{
    public class Cliente
    {
        public string Tipo { get; set; }
        public double MontoCompra { get; set; }
    }

    public class CalculadoraDescuentos
    {
        public double CalcularDescuento(Cliente cliente)
        {
            if (cliente.Tipo == "Regular")
                return cliente.MontoCompra * 0.1; // 10% 
            else if (cliente.Tipo == "Premium")
                return cliente.MontoCompra * 0.2; // 20% 
            else
                return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                Tipo = "Premium",
                MontoCompra = 1000
            };

            CalculadoraDescuentos calculadora = new CalculadoraDescuentos();
            double descuento = calculadora.CalcularDescuento(cliente);
            Console.WriteLine($"Descuento: {descuento}"); // Salida: Descuento: 200
        }
    }
}
