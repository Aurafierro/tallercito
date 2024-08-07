// Definición de la interfaz ISaludar
public interface ISaludar
{
    void Saludar();
}

// Implementación de la interfaz en una clase llamada Persona
public class Persona : ISaludar
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    // Implementación del método Saludar de la interfaz ISaludar
    public void Saludar()
    {
        Console.WriteLine($"¡Hola, mi nombre es {Nombre}!");
    }
}

// Uso de la interfaz y la clase
class Program
{
    static void Main(string[] args)
    {
        ISaludar persona = new Persona("Carlos");
        persona.Saludar();  // Output: ¡Hola, mi nombre es Carlos!
    }
}
