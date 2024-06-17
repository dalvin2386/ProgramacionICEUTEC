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
            string nickname, string password1, DateTime fechaNacimiento, DateTime fechaCreacionUsuario)
            : base(nombreCompleto, identidad, numeroTelefono, correo, nickname, password1, fechaNacimiento, fechaCreacionUsuario) { }


       


    }
}
