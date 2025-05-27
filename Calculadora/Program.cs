using EspacioCalculadora;

double termino = 0;
bool funciona1 = false;
string numString1 = "";
string respuesta;

Calculadora nDato = new Calculadora();
int opcion;
do
{
    Console.WriteLine("\nBienvenido a la Calculadora");
    Console.WriteLine("Seleccione la opción deseada: ");
    Console.WriteLine(" 1) SUMA");
    Console.WriteLine(" 2) RESTA");
    Console.WriteLine(" 3) MULTIPLICACIÓN");
    Console.WriteLine(" 4) DIVISIÓN");
    Console.WriteLine(" 5) LIMPIAR");
    Console.WriteLine(" 6) SALIR");
    Console.Write("Opción: ");

    opcion = Console.ReadKey().KeyChar;

    switch (opcion)
    {
        case '1':

            Console.WriteLine("\nIngrese los terminos en la calculadora: (Para volver al menu principal ingrese cualquier letra)");
            numString1 = Console.ReadLine();
            funciona1 = double.TryParse(numString1, out termino);
            if (!funciona1)
            {
                Console.WriteLine(numString1 + "No es un termino valido");
            }
            else
            {
                nDato.Sumar(termino);
                Console.WriteLine("El Resultado es: " + nDato.Resultado);
            }


            break;
        case '2':

            Console.WriteLine("\nIngrese los terminos en la calculadora: (Para volver al menu principal ingrese cualquier letra)");
            numString1 = Console.ReadLine();
            funciona1 = double.TryParse(numString1, out termino);
            if (!funciona1)
            {
                Console.WriteLine(numString1 + "No es un termino valido");
            }
            else
            {
                nDato.Restar(termino);
                Console.WriteLine("El Resultado es: " + nDato.Resultado);
            }



            break;
        case '3':

            Console.WriteLine("\nIngrese los terminos en la calculadora: (Para volver al menu principal ingrese cualquier letra)");
            numString1 = Console.ReadLine();
            funciona1 = double.TryParse(numString1, out termino);
            if (!funciona1)
            {
                Console.WriteLine(numString1 + "No es un termino valido");
            }
            else
            {
                nDato.Multiplicar(termino);
                Console.WriteLine("El Resultado es: " + nDato.Resultado);
            }

            break;
        case '4':

            Console.WriteLine("\nIngrese los terminos en la calculadora: (Para volver al menu principal ingrese cualquier letra)");
            numString1 = Console.ReadLine();
            funciona1 = double.TryParse(numString1, out termino);
            if (!funciona1)
            {
                Console.WriteLine(numString1 + "No es un termino valido");
            }
            else
            {
                nDato.Dividir(termino);
                Console.WriteLine("El Resultado es: " + nDato.Resultado);
            }

            break;
        case '5':
            nDato.Limpiar();
            break;

        default:
            Console.WriteLine("Ingrese un valor valido");
            break;
    }
    Console.WriteLine("¿Desea realizar otra operacion ?(presione s para continuar u otra tecla/numero para salir)");
    respuesta = Console.ReadLine().ToLower();
} while (respuesta == "s");

