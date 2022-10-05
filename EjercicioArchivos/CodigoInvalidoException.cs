using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    internal class CodigoInvalidoException:ApplicationException
    {
        public CodigoInvalidoException():base("Número de campos inválidos"){}
        public CodigoInvalidoException(string message):base(message){}
        public CodigoInvalidoException(string message, Exception innerException):base(message, innerException){}


    }
}
