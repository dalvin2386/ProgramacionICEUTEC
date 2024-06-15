using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class CuentaBasica : Cuenta
    {
        public CuentaBasica(string idCuenta, string nombre, double balance, double porcentajeInteres)
            : base(idCuenta, nombre, balance, porcentajeInteres) { }

        public override double CalcularInteres()
        {
            return base.Balance * base.PorcentajeInteres;
        }

        public override string ToString()
        {
            return "Cuenta Básica" +
                "\nId de Cuenta: " + IdCuenta
                + "\nNombre: " + Nombre
                + "\nBalance: " + Balance + " Lempiras"
                + "\nPorcentaje de Interes:" + PorcentajeInteres
                + "\nInteres Ganado: " + CalcularInteres() + " Lempiras";
        }
    }
}
