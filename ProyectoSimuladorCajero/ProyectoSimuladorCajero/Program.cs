﻿using ProyectoSimuladorCajero.Modelos;
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


            List<Usuario> usuarios = new List<Usuario>();
            List<Cuenta> cuentas = new List<Cuenta>();           
            int opcionMenuP = 0;
            int opcionMenuCC = 0;
            
            


            do//Genera inicio de sesion y el menu que corresponde segun el usuario
            {
                InicioSesion();
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
                        Console.Write("Nombre completo: ");
                        string nombreCompleto = Console.ReadLine();
                        Console.Write("Identidad: ");
                        string identidad = Console.ReadLine();
                        Console.Write("Móvil: ");
                        string numeroTelefono = Console.ReadLine() ;
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        Console.Write("Usuario: ");
                        string usuario = Console.ReadLine();
                        Console.Write("Contraseña: ");
                        string contrasena = Console.ReadLine();
                        Console.Write("Fecha de nacimiento: ");
                        DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Fecha de creacion: ");
                        DateTime fechaCreacion = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine();

                        UsuarioAdministrador administrador = new UsuarioAdministrador(nombreCompleto, identidad, numeroTelefono, correo, usuario, contrasena, fechaNacimiento, fechaCreacion);
                        usuarios.Add(administrador);
                        Console.WriteLine("Cuenta de usuario creada satisfactoriamente...");

                        break;

                    case 2: // Dar de baja a un usuario
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("||||||||||||||| DAR DE BAJA A UN USUARIO |||||||||||||||");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.Write("Ingrese su nickname: ");
                        usuario = Console.ReadLine();
                        Usuario buscarUsuarioExistente = usuarios.Find(c => c.Nickname==usuario);
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
                        }
                        else if (opcionMenuCC == 2)
                        {
                            CuentaPremium premium = new CuentaPremium(idCuenta, nombre, balance, fechaCrecionCuenta);
                            cuentas.Add(premium);
                            Console.WriteLine("Cuenta creada satisfactoriamente...");
                        }
                        else if (opcionMenuCC == 3)
                        {
                            Console.WriteLine("Gracias por crear su cuenta con nosotros..");
                        }
                        else
                        {
                            Console.WriteLine("Opción Invalida..");
                        }


                        break;
                    case 4: // Dar de baja a una cuenta
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("||||||||||||||| DAR DE BAJA A UNA CUENTA BANCARIA |||||||||||||||");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Cuenta buscarCuentaExistente = cuentas.Find(c => c.IdCuenta == idCuenta);
                        if (buscarCuentaExistente != null)
                        {
                            cuentas.Remove(buscarCuentaExistente);
                            Console.Write("Cuenta eliminada con exito..");
                        }
                        else
                        {
                            Console.Write("Lo sentimos, no hemos encontrado su cuenta..");
                        }

                        break;                                   
                                            
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                
            } while (opcionMenuP != 0);

            
        }
      
        private static void MenuCrearCuentaCliente()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************** CREAR CUENTA ***************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Cuenta Básica");
            Console.WriteLine("2. Cuenta Premium");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una de las opciones: ");
            Console.WriteLine("");
        }

        private static void MenuUsuarioAdministrador()
        {
            Console.WriteLine("Hola" + ", Bienvenido al cajero automático T1474");
            Console.WriteLine("1. Crear Usuario");
            Console.WriteLine("2. Dar de baja a un usuario");
            Console.WriteLine("3. Crear cuenta");
            Console.WriteLine("4. Dar de baja a una cuenta");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una opción: ");
        }

        private static void MenuUsuarioCliente()
        {
            Console.WriteLine("Hola" + " , Bienvenido al cajero automático T1474");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Verificar saldo");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una opción: ");
        }

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
                MenuUsuarioAdministrador();
                Console.WriteLine();
            }
            else if (usuario == nicknameCliente && password == passwordCliente)
            {
                MenuUsuarioCliente();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Su usuario o contrasena son incorrectos. Intentelo de nuevo");
            }

        }




    }
}
