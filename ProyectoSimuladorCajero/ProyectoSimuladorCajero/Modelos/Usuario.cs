using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public abstract class Usuario
    {

        public string NombreCompleto {  get; set; }
        public string Identidad { get; set; }
        public string NumeroTelefono { get; set; }
        public string Correo { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacionUsuario { get; set; }


        public Usuario() { }

        public Usuario(string nombreCompleto, string identidad, string numeroTelefono,string correo, string nickname, string password1, DateTime fechaNacimiento, DateTime fechaCreacionUsuario)
        {
            NombreCompleto  = nombreCompleto;
            Identidad = identidad;
            NumeroTelefono = numeroTelefono;
            Correo = correo;
            Nickname = nickname;
            Password = password1;
            FechaNacimiento = fechaNacimiento;
            FechaCreacionUsuario = fechaCreacionUsuario;
        }


    }

    
}
