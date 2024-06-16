using ProyectoSimuladorCajero.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero
{
    internal class Program
    {

        static void Main(string[] args)
        {

             
            List<Cuenta> cuentas = new List<Cuenta>();
            int opcionMenuP = 0;
            int opcionMenuCC = 0;


            InicioSesion();

            do
            {
                
                opcionMenuP = Convert.ToInt16(Console.ReadLine());
                string idCuenta;
                switch (opcionMenuP)
                {
                    case 1:// Agregar Cuenta
                        Console.WriteLine();
                        MenuCrearCuentaCliente();
                        opcionMenuCC = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Ingrese el Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese monto inicial: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el porcetaje de interes (entre 1 - 100): ");
                        int interes = Convert.ToInt16(Console.ReadLine());
                        if (opcionMenuCC == 1)
                        {
                            CuentaBasica basica = new CuentaBasica(idCuenta, nombre, balance, interes);
                            cuentas.Add(basica);
                            Console.WriteLine("Cuenta creada satisfactoriamente...");
                            Console.WriteLine();
                        }
                        else if (opcionMenuCC == 2)
                        {
                            CuentaPremium premium = new CuentaPremium(idCuenta, nombre, balance, interes);
                            cuentas.Add(premium);
                            Console.WriteLine("Cuenta creada satisfactoriamente...");
                            Console.WriteLine();
                        }
                        else if (opcionMenuCC == 3)
                        {
                            Console.WriteLine("Gracias por preferirnos..");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida..");
                            Console.WriteLine();
                        }

                        break;
                    case 2: // Borrar una Cuenta
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("||||||||||||||| BORRAR CUENTA |||||||||||||||");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Cuenta buscarCuentaExistente = cuentas.Find(c => c.IdCuenta == idCuenta);
                        if (buscarCuentaExistente != null)
                        {
                            cuentas.Remove(buscarCuentaExistente);
                            Console.Write("Cuenta eliminada con exito..");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("Lo sentimos, no hemos encontrado su cuenta..");
                            Console.WriteLine();
                        }
                        break;
                    case 3: // Depositar en la cuenta
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("*************** DEPOSITO ***************");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Monto del deposito: ");
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        foreach (Cuenta elemento in cuentas)
                        {
                            if (elemento.IdCuenta.Equals(idCuenta))
                            {
                                elemento.Deposito(deposito);
                                Console.WriteLine("Deposito exitoso...");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4: // Retirar dinero de la cuenta
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("*************** RETIRO ***************");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Monto del Retiro: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());
                        foreach (Cuenta elemento in cuentas)
                        {
                            if (elemento.IdCuenta.Equals(idCuenta))
                            {
                                elemento.Retiro(retiro);
                                Console.WriteLine("Retiro exitoso...");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5: //Imprimir Reporte
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("*************** REPORTE ***************");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        foreach (Cuenta elemento in cuentas)
                        {
                            Console.WriteLine(elemento);
                            Console.WriteLine();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (opcionMenuP != 0);

        }
        private static void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************** MENU PRINCIPAL ***************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Agregar Cuenta");
            Console.WriteLine("2. Borrar Cuenta");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Retirar");
            Console.WriteLine("5. Imprimir Reporte");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una de las opciones: ");
            Console.WriteLine("");

        }
        private static void MenuCrearCuentaCliente()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************** CREAR CUENTA ***************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Cuenta Básica");
            Console.WriteLine("2. Cuenta Premium");
            Console.WriteLine("3. Salir");
            Console.Write("\nElija una de las opciones: ");
            Console.WriteLine("");
        }

       /* private static void MenuUsuarioAdministrador()
        {
            Console.WriteLine("Hola" + ", Bienvenido al cajero automático T1474");
            Console.WriteLine("1. Crear Usuario");
            Console.WriteLine("2. Dar de baja a un usuario");
            Console.WriteLine("3. Crear cuenta");
            Console.WriteLine("4. Salir");
            Console.Write("\nElija una opción: ");
        }

        private static void MenuUsuarioCliente()
        {
            Console.WriteLine("Hola" + " Dalvin Soriano, Bienvenido al cajero automático T1474");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Verificar saldo");
            Console.WriteLine("4. Salir");
            Console.Write("\nElija una opción: ");
        }*/

        private static void InicioSesion()
        {

            string nicknameAdmin = "dsoriano";
            string passwordAdmin = "1234";
            string nicknameCliente = "ihernandez";
            string passwordCliente = "12345";


            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Ingrese su contrasena: ");
            string password = Console.ReadLine();

            if (usuario == nicknameAdmin && password == passwordAdmin)
            {
                Console.WriteLine("Hola " + nicknameAdmin +", Bienvenido al cajero automático T1474");
                Console.WriteLine();
                Console.WriteLine("1. Crear Usuario");
                Console.WriteLine("2. Dar de baja a un usuario");
                Console.WriteLine("3. Crear cuenta");
                Console.WriteLine("4. Salir");
                Console.Write("\nElija una opción: ");
                Console.WriteLine();
            }
            else if (usuario == nicknameCliente && password == passwordCliente)
            {
                Console.WriteLine("Hola " +nicknameCliente+ ", Bienvenido al cajero automático T1474");
                Console.WriteLine();
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Verificar saldo");
                Console.WriteLine("4. Salir");
                Console.Write("\nElija una opción: ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Su usuario o contrasena son incorrectos. Intentelo de nuevo");
            }

        }


    }
}
