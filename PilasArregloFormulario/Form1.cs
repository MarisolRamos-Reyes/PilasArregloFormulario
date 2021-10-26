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
        int contador = 0;
        int _tope = 0;
        int max = 0;
        MiPilaLibros[] arreglos;

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (_tope <= max)
            {
                arreglos[_tope] = new MiPilaLibros();
                arreglos[_tope].Numero = int.Parse(txtNumero.Text);
                arreglos[_tope].Nombre = txtNombre.Text;
                arreglos[_tope].Fecha = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");
                txtNumero.Clear();
                txtNombre.Clear();
                txtNumero.Focus();
                _tope++;
                contador++;
            }
            if (_tope == max)
            {
                MessageBox.Show("La Pila esta llena!!", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                for (int x = 0; x < max; x++)
                {
                    lstbPila.Items.Add(arreglos[x].Numero.ToString());
                    lstbPila.Items.Add(arreglos[x].Nombre);
                    lstbPila.Items.Add(arreglos[x].Fecha);
                    
                }
                btnPush.Enabled = false;
            }
        }

        private void btnarreglo_Click(object sender, EventArgs e)
        {
            max = int.Parse(txtarreglo.Text);
            arreglos = new MiPilaLibros[max];
            grbarreglo.Visible = false;
            grbLista.Visible = true;
            txtNumero.Focus();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (_tope == contador)
            {
                _tope--;
                contador--;
                for (int x = _tope; x <= max; x--)
                {
                    lstbPila.Items.Add(arreglos[x].Numero.ToString());
                    lstbPila.Items.Add(arreglos[x].Nombre);
                    lstbPila.Items.Add(arreglos[x].Fecha);

                }
                return;
            }
            else
            {
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(arreglos[_tope].Numero == int.Parse(txtNumero.Text))
            {
                arreglos[_tope] = new MiPilaLibros();
                arreglos[_tope].Numero = int.Parse(txtNumero.Text);
                arreglos[_tope].Nombre = txtNombre.Text;
                arreglos[_tope].Fecha = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");
                txtNumero.Clear();
                txtNombre.Clear();
                txtNumero.Focus();
                lstbPila.Items.Add(arreglos[_tope].Numero.ToString());
                lstbPila.Items.Add(arreglos[_tope].Nombre);
                lstbPila.Items.Add(arreglos[_tope].Fecha);
            }
        }
    }
}
