using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class CuentaPremium : Cuenta
    {
        public CuentaPremium(string idCuenta, string nombre, double balance, DateTime fechaCreacionCuenta)
            : base(idCuenta, nombre, balance, fechaCreacionCuenta) { }
       
        public override string ToString()
        {
            return "Cuenta Premium" +
                "\nId de Cuenta: " + IdCuenta
                + "\nNombre: " + Nombre
                + "\nBalance: " + Balance + " Lempiras"                
                + "\nInteres Ganado: " + FechaCreacionCuenta;
        }
    }
}
