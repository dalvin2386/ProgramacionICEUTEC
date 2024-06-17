using ProyectoSimuladorCajero.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero
{
    internal class Program
    {

        static void Main(string[] args)
        {



            string nicknameAdmin = "dsoriano";
            string passwordAdmin = "1234";
            string nicknameCliente = "ihernandez";
            string passwordCliente = "12345";

            List<Usuario> usuarios = new List<Usuario>();
            List<Cuenta> cuentas = new List<Cuenta>();
            

            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Ingrese su contrasena: ");
            string password = Console.ReadLine();

            if (usuario == nicknameAdmin && password == passwordAdmin)
            {
              
                Console.WriteLine();
                int opcionMenuP = 0;
                int opcionMenuCC = 0;
                int opcionMenuCU = 0;




                do//Genera inicio de sesion y el menu que corresponde segun el usuario
                {

                    MenuUsuarioAdministrador();
                    opcionMenuP = Convert.ToInt16(Console.ReadLine());
                    string idCuenta;
                    switch (opcionMenuP)
                    {
                        case 1:// Agregar Cuenta de usuario
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("*************** CREAR USUARIO ***************");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            MenuCrearUsuario();
                            Console.WriteLine();
                            opcionMenuCU = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Nombre completo: ");
                            string nombreCompleto = Console.ReadLine();
                            Console.Write("Identidad: ");
                            string identidad = Console.ReadLine();
                            Console.Write("Móvil: ");
                            string numeroTelefono = Console.ReadLine();
                            Console.Write("Correo: ");
                            string correo = Console.ReadLine();
                            Console.Write("Usuario: ");
                            string nickname = Console.ReadLine();
                            Console.Write("Contraseña: ");
                            string contrasena = Console.ReadLine();
                            Console.Write("Fecha de nacimiento: ");
                            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Fecha de creacion: ");
                            DateTime fechaCreacion = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine();

                            if (opcionMenuCU == 1)
                            {
                                UsuarioAdministrador administrador = new UsuarioAdministrador(nombreCompleto, identidad, numeroTelefono, correo, nickname, contrasena, fechaNacimiento, fechaCreacion);
                                usuarios.Add(administrador);
                                Console.WriteLine("Cuenta de usuario creada satisfactoriamente...");
                                Console.WriteLine();

                                break;
                            }
                            else if (opcionMenuCU == 2)
                            {
                                UsuarioCliente cliente = new UsuarioCliente(nombreCompleto, identidad, numeroTelefono, correo, nickname, contrasena, fechaNacimiento, fechaCreacion);
                                usuarios.Add(cliente);
                                Console.WriteLine("Cuenta de usuario creada satisfactoriamente...");
                                Console.WriteLine();

                                break;
                            }                            
                            else
                            {
                                Console.WriteLine("Opción Invalida..");
                            }
                            break;

                        case 2: // Dar de baja a un usuario
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("||||||||||||||| DAR DE BAJA A UN USUARIO |||||||||||||||");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.Write("Ingrese su nickname: ");
                            nickname = Console.ReadLine();
                            Usuario buscarUsuarioExistente = usuarios.Find(c => c.Nickname == nickname);
                            if (buscarUsuarioExistente != null)
                            {
                                usuarios.Remove(buscarUsuarioExistente);
                                Console.Write("Cuenta eliminada con exito..");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write("Lo sentimos, no hemos encontrado su cuenta..");
                                Console.WriteLine();
                            }
                            break;
                    
                        case 3: // Crear cuenta
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("*************** CREAR UNA CUENTA BANCARIA ***************");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            Console.WriteLine();
                            MenuCrearCuentaCliente();
                            Console.WriteLine();
                            opcionMenuCC = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Ingrese Numero de Cuenta: ");
                            idCuenta = Console.ReadLine();
                            Console.Write("Ingrese el Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese monto inicial: ");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese fecha de creacion de la cuenta: ");
                            DateTime fechaCrecionCuenta = Convert.ToDateTime(Console.ReadLine());
                            if (opcionMenuCC == 1)
                            {
                                CuentaBasica basica = new CuentaBasica(idCuenta, nombre, balance, fechaCrecionCuenta);
                                cuentas.Add(basica);
                                Console.WriteLine("Cuenta creada satisfactoriamente...");
                                Console.WriteLine();
                                break;
                            }
                            else if (opcionMenuCC == 2)
                            {
                                CuentaPremium premium = new CuentaPremium(idCuenta, nombre, balance, fechaCrecionCuenta);
                                cuentas.Add(premium);
                                Console.WriteLine("Cuenta creada satisfactoriamente...");
                                Console.WriteLine();
                            }                          
                            else
                            {
                                Console.WriteLine("Opción Invalida..");
                                Console.WriteLine();
                            }


                            break;
                        case 4: // Dar de baja a una cuenta
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("||||||||||||||| DAR DE BAJA A UNA CUENTA BANCARIA |||||||||||||||");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
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

                        default:
                            Console.WriteLine("Opción no válida");
                            Console.WriteLine();
                            break;
                    }

                } while (opcionMenuP != 0);
            }
            else if (usuario == nicknameCliente && password == passwordCliente)
            {
                int opcionMenuC = 4;
               
                Console.WriteLine();
                

                do
                {
                    MenuUsuarioCliente();
                    opcionMenuC = Convert.ToInt16(Console.ReadLine());
                    string idCuenta;
                    switch (opcionMenuC)
                    {

                        case 1://Depositar dinero

                            opcionMenuC = 1;
                            Console.WriteLine();
                            Console.WriteLine("=================DEPOSITO=================");
                            Console.Write("Ingrese Numero de Cuenta: ");
                            idCuenta = Console.ReadLine();
                            Console.Write("Monto del deposito: ");
                            double deposito = Convert.ToDouble(Console.ReadLine());
                            foreach (Cuenta elemento in cuentas)
                            {
                                if (elemento.IdCuenta.Equals(idCuenta))
                                {
                                    elemento.Deposito(deposito);
                                    Console.WriteLine();
                                    Console.WriteLine("Deposito exitoso...");
                                    Console.WriteLine();
                                }
                            }

                            break;
                        case 2://Retirar dinero
                            opcionMenuC = 2;
                            Console.WriteLine();
                            Console.WriteLine("=================RETIRO=================");
                            Console.Write("Ingrese Numero de Cuenta: ");
                            idCuenta = Console.ReadLine();
                            Console.Write("Monto del Retiro: ");
                            double retiro = Convert.ToDouble(Console.ReadLine());
                            foreach (Cuenta elemento in cuentas)
                            {
                                if (elemento.IdCuenta.Equals(idCuenta))
                                {
                                    elemento.Retiro(retiro);
                                    Console.WriteLine();
                                    Console.WriteLine("Retiro exitoso...");
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case 3://Vericar Saldo
                            opcionMenuC = 3;
                            Console.WriteLine("El saldo actual de la cuenta es: L. ");
                            break;
                        default:
                            break;

                    }

                } while (opcionMenuC != 0);


            }
            else
            {
                Console.WriteLine("Su usuario o contrasena son incorrectos. Intentelo de nuevo");
            }

        }
      
        private static void MenuCrearCuentaCliente()
        {
            Console.WriteLine();
            Console.WriteLine("1. Cuenta Básica");
            Console.WriteLine("2. Cuenta Premium");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una de las opciones: ");
            Console.WriteLine("");
            
        }

        private static void MenuCrearUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("1. Usuario Administrador");
            Console.WriteLine("2. Usuario Cliente");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una de las opciones: ");
            Console.WriteLine("");

        }

        private static void MenuUsuarioAdministrador()
        {
            Console.WriteLine("Hola" + ", Bienvenido al cajero automático T1474");
            Console.WriteLine();
            Console.WriteLine("1. Crear Usuario");
            Console.WriteLine("2. Dar de baja a un usuario");
            Console.WriteLine("3. Crear cuenta");
            Console.WriteLine("4. Dar de baja a una cuenta");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una opción: ");
            Console.WriteLine();

        }

        private static void MenuUsuarioCliente()
        {
            Console.WriteLine("Hola" + " , Bienvenido al cajero automático T1474");
            Console.WriteLine();
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Verificar saldo");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una opción: ");
            Console.WriteLine();

        }

       




    }
}
