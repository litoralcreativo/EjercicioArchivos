using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EjercicioArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresa miEmpresa=null;
        FileStream archivos;
        string archivoBackUp = Application.StartupPath + @"\datos.dat";

     
        private void bIniciar_Click(object sender, EventArgs e)
        {
            miEmpresa = new Empresa();
            listBox1.Items.Clear();
            Vendedor nuevo;
            nuevo = new Basico(100, 12000);
            miEmpresa.AgregarVEndedor(nuevo);
            nuevo = new Basico(300, 12000);
            miEmpresa.AgregarVEndedor(nuevo);
            nuevo = new Contratado(200, 30000);
            miEmpresa.AgregarVEndedor(nuevo);
            nuevo = new Basico(400, 25000);
            miEmpresa.AgregarVEndedor(nuevo);
           
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("total: " + miEmpresa.Cantidad);

            for (int i = 0; i < miEmpresa.Cantidad; i++)
            {
                listBox1.Items.Add(miEmpresa.VerVendedor(i).ToString());
            }
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FileStream archivo=null;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    miEmpresa.ProcesarArchivo(archivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ ex.InnerException.Message);
                    listBox1.Items.Clear();
                    listBox1.Items.Add(":'(");
                }
                finally
                {
                    archivo.Dispose();
                }
                
            }
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //if (File.Exists(archivoBackUp))
            //    File.Delete(archivoBackUp);
            FileStream archivo = new FileStream(archivoBackUp, FileMode.Create, FileAccess.Write);
            BinaryFormatter datos = new BinaryFormatter();
            datos.Serialize(archivo,miEmpresa);
            archivo.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(archivoBackUp))
            {
                FileStream archivo = new FileStream(archivoBackUp, FileMode.Open, FileAccess.Read);
                BinaryFormatter datos = new BinaryFormatter();
                miEmpresa = (Empresa)datos.Deserialize(archivo);
                archivo.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
             GuardarDatos();    
        }
        private void GuardarDatos()
        {
            if (File.Exists(archivoBackUp))
            {
                File.Delete(archivoBackUp);
            }
            FileStream archivo = new FileStream(archivoBackUp, FileMode.CreateNew, FileAccess.Write);
            BinaryFormatter datos = new BinaryFormatter();
            datos.Serialize(archivo, miEmpresa);
            archivo.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}
