using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasArregloFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cadena;
        MiPilaLibros x = new MiPilaLibros();
        int cont = 0;

        private void btnPush_Click(object sender, EventArgs e)
        {
            //int numero = int.Parse(txtNumero.Text);
            ////string nombre = txtNombre.Text;
            //NodoPilaLibros NodoNuevo = new NodoPilaLibros(numero, nombre);
            for (int i = 0; i < 10;)
            {
                int numero = int.Parse(txtNumero.Text);
                string nombre = txtNombre.Text;
                cont = i + 1;
                NodoPilaLibros NodoNuevo = new NodoPilaLibros(numero, nombre);
                x.Push(numero,NodoNuevo);
            }
            x.Mostrar(lstVLibros);
            //}
            //else
            //{
            //    MessageBox.Show("El arreglo se lleno",
            //    "Arreglos Unidimensionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
