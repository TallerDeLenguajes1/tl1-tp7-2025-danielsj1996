namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public enum EstadoCivil
{
    casado = 0,
    soltero = 1
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private EstadoCivil estadoCivil;
    private DateTime fechaIng;
    private double sueldoBasico;
    private Cargos cargos;

    public Empleado(string nombre, string apellido, DateTime fechaNac, EstadoCivil estadoCivil, DateTime fechaIng, double sueldoBasico, Cargos cargos)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.estadoCivil = estadoCivil;
        this.fechaIng = fechaIng;
        this.sueldoBasico = sueldoBasico;
        this.cargos = cargos;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public EstadoCivil EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargos { get => cargos; set => cargos = value; }

    public int Antiguedad()
    {
        DateTime fechaActual = DateTime.Today;
        int antiguedad = fechaActual.Year - fechaIng.Year;
        if (fechaIng.Date > fechaActual.AddYears(-antiguedad))
            antiguedad--;
        return antiguedad;
    }

    public int Edad()
    {
        DateTime fechaActual = DateTime.Today;
        int edad = fechaActual.Year - fechaNac.Year;
        if (fechaNac.Date > fechaActual.AddYears(-edad))
        {
            edad--;
        }

        return edad;
    }

    public void Jubilacion()
    {
        int edad = Edad();
        int añosRestantes = 65 - edad;

        if (edad >= 65)
        {
            Console.WriteLine("El empleado puede jubilarse");
        }
        else
        {
            Console.WriteLine($"Al Empleado le faltan {añosRestantes} años para jubilarse");
        }
    }

    public int AñosParaJubilarse()
    {
        int edad = Edad();
        return Math.Max(65 - edad, 0);
    }

    public double SalarioEmpleado()
    {
        double adicional;
        int antiguedad = Antiguedad();

        if (antiguedad <= 20)
        {
            adicional = sueldoBasico * (antiguedad / 100.0);
        }
        else
        {
            adicional = sueldoBasico * 0.25;
        }

        if (cargos == Cargos.Ingeniero || cargos == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (estadoCivil == EstadoCivil.casado)
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }

    public void MostrarEmpleados(){

    Console.WriteLine($"Nombre: {Nombre} {Apellido}");
    Console.WriteLine($"Edad: {Edad()} años");
    Console.WriteLine($"Antigüedad: {Antiguedad()} años");
    Console.WriteLine($"Salario del Empleado : ${SalarioEmpleado():N0}");
    Jubilacion();
    Console.WriteLine("\n");

    }
}