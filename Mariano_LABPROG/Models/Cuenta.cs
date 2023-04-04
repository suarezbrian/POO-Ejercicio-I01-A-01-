using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariano_LABPROG.Models
{
    internal class Cuenta
    {
        private int titular;
        private int cantidad;

        public Cuenta(int titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public int getTitular() {  return this.titular; }
        public int getCantidad() { return this.cantidad; }
        
        public void Mostrar()
        {
            Console.WriteLine("\nEl titular {0}, cuenta {1}", this.titular, this.cantidad);
        }

        public void Ingresar(int cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(int cantidad)
        {
              this.cantidad -= cantidad;                          
        }
    }
}
