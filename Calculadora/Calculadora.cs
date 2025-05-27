namespace EspacioCalculadora;


public class Calculadora
{
    private double resultado = 0;
    public double Resultado { get => resultado;}



    public void Sumar(double termino)
    {
        resultado = resultado + termino;
    }
    public void Restar(double termino)
    {
        resultado = resultado - termino;
    }
    public void Multiplicar(double termino)
    {
        resultado = resultado * termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            resultado = resultado / termino;
        }
        else
        {
            Console.WriteLine("No se puede realizar la division por cero. ");
        }
    }
    public void Limpiar()
    {
        resultado = 0;
        Console.WriteLine("Resultado volvio a su valor original: " + resultado);
    }

    public void mostrar()
    {
        Console.WriteLine("El resultado es: " + resultado);
    }


}