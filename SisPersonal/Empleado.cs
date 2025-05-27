using System.Data;
namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIng;
    private double sueldoBasico;
    private Cargos cargos;

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIng, double sueldoBasico, Cargos cargos)
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
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargos { get => cargos; set => cargos = value; }
    public double Antiguedad()
    {
        DateTime fechaActual = DateTime.Today;

        return fechaActual.Year - fechaIng.Year;
    }

    public double Edad()
    {
        DateTime fechaActual = DateTime.Today;

        return fechaActual.Year - fechaNac.Year;
    }

    public void Jubilacion()
    {
        DateTime fechaActual = DateTime.Today;
        double antiguedad = this.Antiguedad();
        double edad = this.Edad();
        if (edad >= 65 && antiguedad >= 30)
        {
            Console.WriteLine("El empleado puede jubilarse");
        }else
        {
            Console.WriteLine("No posee los requisitos necesarios para jubilarse");
            
        }
        
    }
}

// a. Calcular lo siguiente:
// i. La antigüedad del empleado en la empresa.
// ii. La edad del empleado,
// iii. La cantidad de años que le falta al empleado para poder
// jubilarse, considerando que la edad de jubilación es de 65.
// b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
// Adicional. Para ello el Adicional contempla la antigüedad en años, el
// cargo y si es casado:
// i) 1 % del sueldo básico por cada año de antigüedad hasta los
// 20 años, a partir de este, el porcentaje se fija en 25%.
// ii) Si el cargo es Ingeniero o Especialista, el Adicional se
// incrementa en un 50%.
// iii) Si es casado al Adicional se le aumenta $150.000.
// Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
// $650.000, el Adicional es 65.0000 * 0.15 = 97.500. Si además el
// cargo es Ingeniero o Especialista, se incrementa el Adicional en
// un 50%. Esto es: 97.500* 1.50 = 146.250. Si a su vez es casado
// el Adicional será: 146.250+ 150.000= 296.250
