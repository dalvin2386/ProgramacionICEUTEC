using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class CuentaPremium : Cuenta
    {
        public CuentaPremium(string idCuenta, string nombre, double balance, double porcentajeInteres)
            : base(idCuenta, nombre, balance, porcentajeInteres) { }
        public override double CalcularInteres()
        {
            double InteresesCalculados = 0;
            if (base.Balance > 20000)
            {
                InteresesCalculados = base.Balance * base.PorcentajeInteres + base.Balance * 0.15;
            }
            else
            {
                InteresesCalculados = base.Balance * base.PorcentajeInteres;
            }

            return InteresesCalculados;
        }
        public override string ToString()
        {
            return "Cuenta Premium" +
                "\nId de Cuenta: " + IdCuenta
                + "\nNombre: " + Nombre
                + "\nBalance: " + Balance + " Lempiras"
                + "\nPorcentaje de Interes:" + PorcentajeInteres
                + "\nInteres Ganado: " + CalcularInteres() + " Lempiras";
        }
    }
}
