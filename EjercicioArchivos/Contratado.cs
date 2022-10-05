using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    [Serializable]
    class Contratado : Vendedor
    {
        double montoVentas = 0;
        public Contratado(int codigo, double sueldoBase) : base(codigo, sueldoBase)
        {
                
        }
        public override void AgregarVenta(double monto, int comision)
            {
            montoVentas += monto * (comision / 100.0);
            if (montoVentas > 10000)
                Sueldo += montoVentas;
            else if (montoVentas > 50000)
                Sueldo += montoVentas*1.3;
            }
    }
}
