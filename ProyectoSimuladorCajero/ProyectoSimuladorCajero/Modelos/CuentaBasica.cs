using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public class CuentaBasica : Cuenta
    {
        public CuentaBasica(string idCuenta, string nombre, double balance, DateTime fechaCreacionCuenta)
            : base(idCuenta, nombre, balance, fechaCreacionCuenta) { }

      

        
    }
}
