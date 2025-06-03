using EspacioEmpleado;

Console.WriteLine("Hello, World!\n");

// c. Arreglo de 3 empleados
Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado(
    "Daniel",
     "Juarez",
      new DateTime(1996, 2, 1),
       EstadoCivil.soltero,
    new DateTime(2023, 5, 23),
     450000,
     Cargos.Ingeniero
);

empleados[1] = new Empleado(
    "Pablo",
    "Juarez",
     new DateTime(1994, 7, 7),
      EstadoCivil.soltero,
    new DateTime(2015, 4, 19),
     650000,
      Cargos.Administrativo
);

empleados[2] = new Empleado(
    "Ruben",
    "Juarez",
    new DateTime(1964, 1, 5),
    EstadoCivil.casado,
    new DateTime(1981, 2, 15),
    750000,
    Cargos.Especialista
);
// Mostrar datos de cada empleado

foreach (var emp in empleados)
{
    emp.MostrarEmpleados();
}


// d. Total salarios
double totalSalarios = 0;
foreach (var emp in empleados)
{
    totalSalarios += emp.SalarioEmpleado();
}
Console.WriteLine($"El monto total en concepto de salarios es: ${totalSalarios:N0}\n");

// e. Empleado más próximo a jubilarse
Empleado? masProximo = null;
int menorDiferencia = int.MaxValue;

foreach (var emp in empleados)
{
    int diferencia = emp.AñosParaJubilarse();
    if (diferencia > 0 && diferencia < menorDiferencia)
    {
        menorDiferencia = diferencia;
        masProximo = emp;
    }
}
if (masProximo != null)
{
    Console.WriteLine("Empleado más próximo a jubilarse:");
    Console.WriteLine($"Nombre: {masProximo.Nombre} {masProximo.Apellido}");
    Console.WriteLine($"Edad: {masProximo.Edad()} años");
    Console.WriteLine($"Antigüedad: {masProximo.Antiguedad()} años");
    Console.WriteLine($"Años para jubilarse: {menorDiferencia}");
    Console.WriteLine($"Salario: ${masProximo.SalarioEmpleado():N0}");

}else
{
    Console.WriteLine("Todos los empleados ya están jubilados. ");
}
