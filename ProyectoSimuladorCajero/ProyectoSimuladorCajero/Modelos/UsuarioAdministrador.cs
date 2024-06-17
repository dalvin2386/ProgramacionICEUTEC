using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class UsuarioAdministrador : Usuario
    {
        public UsuarioAdministrador(string nombreCompleto, string identidad, string numeroTelefono, string correo,
            string nickname, string password1, DateTime fechaNacimiento, DateTime fechaCreacionUsuario)
            : base(nombreCompleto, identidad, numeroTelefono, correo, nickname, password1, fechaNacimiento, fechaCreacionUsuario) { }


        public override string ToString()
        {
            return "Usuario Administrador" +
                "\nNombre completo: " + NombreCompleto
                + "\nIdentidad: " + Identidad
                + "\nNumero de telefono: " + NumeroTelefono
                + "\nCorreo:" + Correo
                + "\nUsuario:" + Nickname
                + "\nContraseña:" + Password
                + "\nFecha Nacimiento:" + FechaNacimiento
                + "\nFecha de creaci[on de usuario: " + FechaCreacionUsuario;



        }
    }
}