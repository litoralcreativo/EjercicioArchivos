using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    [Serializable]
    class Basico: Vendedor
    {
        
        public Basico(int codigo, double sueldoBase) : base(codigo, sueldoBase)
        {
          
        }
        public override void AgregarVenta(double monto, int comision)
        {
            Sueldo += monto * (comision / 100.0);
        }
       
    }
}
