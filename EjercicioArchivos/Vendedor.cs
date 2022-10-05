using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    [Serializable]
    abstract class  Vendedor:IComparable
    {
        public int Codigo
        {
            set; get;
        }
        public double Sueldo
        {
            set; get;
        }
        public Vendedor(int codigo, double sueldoBase)
        {
            Codigo = codigo;
            Sueldo = sueldoBase;
        }
        public abstract void AgregarVenta(double monto, int comision);
        public override string ToString()
        {
            return Codigo + " Sueldo: " + Sueldo;
        }

        public int CompareTo(object obj)
        {
            return Codigo.CompareTo(((Vendedor)obj).Codigo); 
        }

    }
}
