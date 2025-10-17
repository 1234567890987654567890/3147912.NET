//=============================================15 OCTUBRE=========================================================

//Console.WriteLine("Ingrese su edad: .");
//int numero = int.Parse(Console.ReadLine());
//Console.WriteLine($"Su edad es: {numero}");

//Console.WriteLine("ingrese su nota 1: ");
//float nota1 = float.Parse(Console.ReadLine());
//Console.WriteLine("ingrese su nota 2: ");
//float nota2 = float.Parse(Console.ReadLine());
//Console.WriteLine("ingrese su nota 3: ");
//float nota3 = float.Parse(Console.ReadLine());

//float promedio = (nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f);
//if (promedio >= 3)
//{
//    Console.WriteLine("aprobado");
//}
//else
//{
//    Console.WriteLine("reprobado");
//}


//ejercicio#2

//Console.WriteLine("Ingrese el precio del producto: ");
//float precio = float.Parse(Console.ReadLine());

//if (precio >= 100000)
//{
//    float descuento = precio * 0.10f;
//    float total = precio - descuento;
//    Console.WriteLine("Se aplicó un 10% de descuento.");
//    Console.WriteLine("El precio final es: " + total);
//}
//else
//{
//    Console.WriteLine("No se aplica descuento.");
//    Console.WriteLine("El precio final es: " + precio);
//}



//prestamo del estudiante

//Console.WriteLine("Ingrese el monto del préstamo: ");
//float monto = float.Parse(Console.ReadLine());

//float interesAnual = monto * 0.05f;
//float interesTrimestre = interesAnual / 4;
//float interesMes = interesAnual / 12;

//float totalPagar = monto + (interesAnual * 5);

//Console.WriteLine("Interes pagado en un año: " + interesAnual);
//Console.WriteLine("Interes pagado en el tercer trimestre: " + interesTrimestre);
//Console.WriteLine("Interes pagado en el primer mes: " + interesMes);
//Console.WriteLine("Total a pagar incluyendo intereses: " + totalPagar);






//=================================================ACTIVIDAD 17 OCTUBRE=============================================
Console.WriteLine("TALLER ESTRUCTURA DE CONTROL");
Console.WriteLine("1. Colilla de pago");
Console.WriteLine("2. Pago de matrícula");
Console.Write("Seleccione una opción (1 o 2): ");
int opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    // Colilla de pago
    Console.Write("Ingrese el salario del empleado: ");
    double salario = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor del ahorro mensual programado: ");
    double ahorro = double.Parse(Console.ReadLine());

    double salud = salario * 0.125;
    double pension = salario * 0.16;
    double totalRecibir = salario - (salud + pension + ahorro);

    Console.WriteLine("\n--- COLILLA DE PAGO ---");
    Console.WriteLine("Salario: $" + salario);
    Console.WriteLine("Ahorro mensual: $" + ahorro);
    Console.WriteLine("Aporte salud (12.5%): $" + salud);
    Console.WriteLine("Aporte pensión (16%): $" + pension);
    Console.WriteLine("Total a recibir: $" + totalRecibir);
}
else if (opcion == 2)
{
    // Pago de matrícula
    Console.Write("Ingrese el valor total de la matrícula: ");
    double matricula = double.Parse(Console.ReadLine());

    double cuota1 = matricula * 0.40;
    double cuota2 = matricula * 0.25;
    double cuota3 = matricula * 0.20;
    double cuota4 = matricula * 0.15;

    Console.WriteLine("\n--- CUOTAS DE MATRÍCULA ---");
    Console.WriteLine("Primera cuota (40%): $" + cuota1);
    Console.WriteLine("Segunda cuota (25%): $" + cuota2);
    Console.WriteLine("Tercera cuota (20%): $" + cuota3);
    Console.WriteLine("Cuarta cuota (15%): $" + cuota4);
}
else
{
    Console.WriteLine("Opción no válida.");
}

Console.WriteLine("\nFin del programa.");
