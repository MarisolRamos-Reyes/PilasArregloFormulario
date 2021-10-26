using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasArregloFormulario
{
    class MiPilaLibros
    {
        public int numero;
        public string nombre;
        public string fecha;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public MiPilaLibros()
        {
            numero = 0;
            nombre = "";
            fecha = "";
        }
        //public MiPilaLibros[]Push(MiPilaLibros[]A, int i)
        //{
        //    int numero = int.Parse(txtNumero.Text);
        //    string nombre = txtNombre.Text;
        //}
        //public void Mostrar(ListView caja)
        //{
        //    caja.Items.Clear();
        //    NodoPilaLibros t = _tope;
        //    while (t != null) 
        //    {
        //        ListViewItem datos = new ListViewItem
        //            (Convert.ToString(t.numero));
        //        datos.SubItems.Add(t.nombre);
        //        caja.Items.Add(datos);
        //        t = t.Siguiente;
        //    }
        //}
    }
}
