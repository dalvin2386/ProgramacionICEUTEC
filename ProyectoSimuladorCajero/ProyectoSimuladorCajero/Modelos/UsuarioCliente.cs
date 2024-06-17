using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class UsuarioCliente : Usuario
    {
        public UsuarioCliente(string nombreCompleto, string identidad, string numeroTelefono, string correo,
            string nickname, string password, DateTime fechaNacimiento, DateTime fechaCreacionUsuario)
            : base(nombreCompleto, identidad, numeroTelefono, correo, nickname, password, fechaNacimiento, fechaCreacionUsuario) { }


        public override string ToString()
        {
            return "Usuario Cliente" +
                "\nNombre completo: " + NombreCompleto
                + "\nIdentidad: " + Identidad
                + "\nNumero de telefono: " + NumeroTelefono
                + "\nCorreo:" + Correo
                + "\nNickname:" + Nickname
                + "\nPassword:" + Password
                + "\nFecha Nacimiento:" + FechaNacimiento
                + "\nFecha de creaci[on de usuario: " + FechaCreacionUsuario;
            
               

        }


    }
}
