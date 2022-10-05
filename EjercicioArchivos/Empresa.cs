using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjercicioArchivos
{
    [Serializable]
    class Empresa
    {
        int cantidad;
        public int Cantidad
            { set { cantidad = value; }
              get { return cantidad; }      
            }
        List<Vendedor> lista = new List<Vendedor>();
        public void AgregarVEndedor(Vendedor v)
        {
            lista.Add(v);
            lista.Sort();
            cantidad = lista.Count;
            
        }
        public Vendedor VerVendedor(int c)
        {
            return lista[c];
        }
        public Vendedor BuscarVendedor(int c)
        {
            Vendedor buscado = null;
            foreach (Vendedor v in lista)
                if (c == v.Codigo)
                    buscado = v;
            return buscado;
        }
        public void ProcesarArchivo (FileStream archivo)
        {
            StreamReader sr = new StreamReader(archivo);
            string[] campos;
            int counter = 0;
            Vendedor v;
            try
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    campos = line.Split(';');
                    counter++;

                    if (campos.Length !=3) 
                        throw new CodigoInvalidoException();

                    int legajo = Convert.ToInt32(campos[0]);
                    v = BuscarVendedor(legajo);

                    if (v != null)
                    {
                        v.AgregarVenta(Convert.ToDouble(campos[1]), Convert.ToInt32(campos[2]));
                    }
                    else
                    {
                        v = new Contratado(legajo, 20000);
                        v.AgregarVenta(Convert.ToDouble(campos[1]), Convert.ToInt32(campos[2]));
                        AgregarVEndedor(v);
                    }
                }   
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la línea "+counter+": ", ex);
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
