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
        public int NumeroTelefono { get; set; }
        public string Correo { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacionUsuario { get; set; }


        public Usuario() { }

        public Usuario(string nombreCompleto, string identidad, int numeroTelefono, string nickname, string password, DateTime fechaNacimiento, DateTime fechaCreacionUsuario)
        {
            NombreCompleto  = nombreCompleto;
            Identidad = identidad;
            NumeroTelefono = numeroTelefono;
            Nickname = nickname;
            Password = password;
            FechaNacimiento = fechaNacimiento;
            FechaCreacionUsuario = fechaCreacionUsuario;
        }


    }

    
}
