using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimuladorCajero.Modelos
{
    public abstract class Cuenta
    {
        public string IdCuenta { get; set; }
        public string Nombre { get; set; }
        public double Balance { get; set; }
        public DateTime FechaCreacionCuenta { get; set; }

        
        public Cuenta() { }

        public Cuenta(string idCuenta, string nombre, double balance, DateTime fechaCreacionCuenta)
        {
            IdCuenta = idCuenta;
            Nombre = nombre;
            Balance = balance;
            FechaCreacionCuenta = fechaCreacionCuenta;
        }

       

        public void Deposito(double monto)
        {
            if (monto > 0)
            {
                Balance += monto;
            }
        }
        public void Retiro(double monto)
        {
            if (monto <= Balance)
            {
                Balance -= monto;
            }
        }

       
    }
}
