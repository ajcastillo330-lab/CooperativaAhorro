using System;

class Program
{
    static void Main(string[] args)
    {
        string opcionMenuPrincipal = "";

        // Menú Principal con do-while
        do
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("    COOPERATIVA 'AHORRO SEGURO' - MENÚ");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Ejercicio 1: Cajero Automático");
            Console.WriteLine("2. Ejercicio 2: Simulador de Préstamo");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcionMenuPrincipal = Console.ReadLine();

            switch (opcionMenuPrincipal)
            {
                case "1":
                    // ==========================================
                    // EJERCICIO 1: CAJERO AUTOMÁTICO
                    // ==========================================
                    Console.Clear();
                    Console.WriteLine("--- CAJERO AUTOMÁTICO ---");

                    string pinCorrecto = "1234";
                    int intentos = 3;
                    bool accesoConcedido = false;

                    // Validación del PIN con while
                    while (intentos > 0)
                    {
                        Console.Write("Ingrese su PIN de 4 dígitos: ");
                        string pinIngresado = Console.ReadLine();

                        if (pinIngresado == pinCorrecto)
                        {
                            accesoConcedido = true;
                            break;
                        }
                        else
                        {
                            intentos--;
                            Console.WriteLine($"PIN incorrecto. Le quedan {intentos} intentos.");
                        }
                    }

                    if (!accesoConcedido)
                    {
                        Console.WriteLine("\nSu cuenta ha sido bloqueada por seguridad. Presione una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    }

                    // Variables del cajero
                    double saldo = 10000.00;
                    int cantDepositos = 0;
                    int cantRetiros = 0;
                    string opcionCajero = "";

                    // Menú interno del cajero con do-while
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("--- MENÚ CAJERO AUTOMÁTICO ---");
                        Console.WriteLine("1. Consultar saldo");
                        Console.WriteLine("2. Depositar dinero");
                        Console.WriteLine("3. Retirar dinero");
                        Console.WriteLine("4. Salir al menú principal");
                        Console.Write("Elija una opción: ");
                        opcionCajero = Console.ReadLine();

                        if (opcionCajero == "1")
                        {
                            Console.WriteLine($"\nSu saldo actual es: RD$ {saldo:N2}");
                        }
                        else if (opcionCajero == "2")
                        {
                            Console.Write("\nIngrese el monto a depositar: ");
                            if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
                            {
                                saldo += deposito;
                                cantDepositos++;
                                Console.WriteLine($"Depósito exitoso. Nuevo saldo: RD$ {saldo:N2}");
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido. Debe ser mayor a cero.");
                            }
                        }
                        else if (opcionCajero == "3")
                        {
                            Console.Write("\nIngrese el monto a retirar (múltiplo de 100): ");
                            if (double.TryParse(Console.ReadLine(), out double retiro) && retiro > 0)
                            {
                                if (retiro > saldo)
                                {
                                    Console.WriteLine("Fondos insuficientes para realizar el retiro.");
                                }
                                else if (retiro % 100 != 0)
                                {
                                    Console.WriteLine("El monto del retiro debe ser un múltiplo de RD$ 100.");
                                }
                                else
                                {
                                    saldo -= retiro;
                                    cantRetiros++;
                                    Console.WriteLine($"Retiro exitoso. Nuevo saldo: RD$ {saldo:N2}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido.");
                            }
                        }
                        else if (opcionCajero == "4")
                        {
                            Console.WriteLine("\nSaliendo del cajero...");
                            Console.WriteLine($"Total de depósitos realizados: {cantDepositos}");
                            Console.WriteLine($"Total de retiros realizados: {cantRetiros}");
                            Console.WriteLine($"Saldo final en la cuenta: RD$ {saldo:N2}");
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida.");
                        }

                        if (opcionCajero != "4")
                        {
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                        }

                    } while (opcionCajero != "4");

                    Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
                    Console.ReadKey();
                    break;

                case "2":
                    // ==========================================
                    // EJERCICIO 2: SIMULADOR DE PRÉSTAMO
                    // ==========================================
                    string repetirSimulacion = "S";

                    while (repetirSimulacion == "S" || repetirSimulacion == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("--- SIMULADOR DE PRÉSTAMO ---");

                        double montoPréstamo = 0;
                        int plazoMeses = 0;
                        char categoriaSocio = ' ';
                        double tasaAnual = 0;

                        // Validar Monto (5,000 a 500,000) con TryParse y while
                        while (true)
                        {
                            Console.Write("Ingrese el monto del préstamo (RD$ 5,000 - 500,000): ");
                            if (double.TryParse(Console.ReadLine(), out montoPréstamo) && montoPréstamo >= 5000 && montoPréstamo <= 500000)
                            {
                                break;
                            }
                            Console.WriteLine("Dato inválido. Intente de nuevo.");
                        }

                        // Validar Plazo (6 a 60 meses) con TryParse y while
                        while (true)
                        {
                            Console.Write("Ingrese el plazo en meses (6 - 60): ");
                            if (int.TryParse(Console.ReadLine(), out plazoMeses) && plazoMeses >= 6 && plazoMeses <= 60)
                            {
                                break;
                            }
                            Console.WriteLine("Dato inválido. Intente de nuevo.");
                        }

                        // Validar Categoría (A, B, C) con while
                        while (true)
                        {
                            Console.Write("Ingrese la categoría del socio (A, B, C): ");
                            string entradaCat = Console.ReadLine().ToUpper();
                            if (entradaCat == "A" || entradaCat == "B" || entradaCat == "C")
                            {
                                categoriaSocio = char.Parse(entradaCat);
                                break;
                            }
                            Console.WriteLine("Categoría inválida. Debe ser A, B o C.");
                        }

                        // Asignar tasa según categoría
                        if (categoriaSocio == 'A') tasaAnual = 0.12;
                        else if (categoriaSocio == 'B') tasaAnual = 0.15;
                        else if (categoriaSocio == 'C') tasaAnual = 0.18;

                        // Cálculos financieros
                        double iMensual = tasaAnual / 12.0;
                        double factor = Math.Pow(1 + iMensual, plazoMeses);
                        double cuotaFija = montoPréstamo * (iMensual * factor) / (factor - 1);

                        Console.Clear();
                        Console.WriteLine("=== RESUMEN DE SIMULACIÓN ===");
                        Console.WriteLine($"Monto: RD$ {montoPréstamo:N2} | Plazo: {plazoMeses} meses | Categoría: {categoriaSocio} (Tasa: {tasaAnual * 100}%)");
                        Console.WriteLine($"Cuota Fija Mensual: RD$ {cuotaFija:N2}\n");

                        Console.WriteLine("--- TABLA DE AMORTIZACIÓN ---");
                        Console.WriteLine("Mes\tCuota\t\tInterés\t\tAbono Cap.\tSaldo");

                        double saldoActual = montoPréstamo;
                        double totalInteresPagado = 0;
                        double totalCapitalPagado = 0;

                        // Bucle for obligatorio para la tabla de amortización
                        for (int mes = 1; mes <= plazoMeses; mes++)
                        {
                            double interesMes = saldoActual * iMensual;
                            double abonoCapital = cuotaFija - interesMes;
                            saldoActual -= abonoCapital;

                            if (mes == plazoMeses && saldoActual < 0) saldoActual = 0;

                            totalInteresPagado += interesMes;
                            totalCapitalPagado += abonoCapital;

                            Console.WriteLine($"{mes}\t{cuotaFija,8:N2}\t{interesMes,8:N2}\t{abonoCapital,8:N2}\t{saldoActual,8:N2}");
                        }

                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine($"Total Intereses Pagados: RD$ {totalInteresPagado:N2}");
                        Console.WriteLine($"Total General Pagado:    RD$ {(totalCapitalPagado + totalInteresPagado):N2}");
                        Console.WriteLine("-------------------------------------------------------------");

                        Console.Write("\n¿Desea simular otro préstamo? (S/N): ");
                        repetirSimulacion = Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("\n¡Gracias por usar el sistema de la Cooperativa Ahorro Seguro! Saliendo...");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Presione una tecla para intentar de nuevo.");
                    Console.ReadKey();
                    break;
            }

            if (opcionMenuPrincipal != "3")
            {
                Console.WriteLine("\nPresione cualquier tecla para regresar al menú principal...");
                Console.ReadKey();
            }

        } while (opcionMenuPrincipal != "3");
    }
}
