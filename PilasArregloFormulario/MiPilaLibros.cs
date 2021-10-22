using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasArregloFormulario
{
    class MiPilaLibros:NodoPilaLibros
    {
        public NodoPilaLibros _tope;
        public NodoPilaLibros Tope
        {
            get { return _tope; }
            set { _tope = value; }
        }
        public MiPilaLibros()
        {
            _tope = null;
        }
        public void Push (int valor, NodoPilaLibros unNodo)
        {
            unNodo.numero = valor;
            if (_tope == null)
            {
                _tope = unNodo;
                return;
            }
            unNodo.siguiente = _tope;
            _tope = unNodo;
        }
        public void Mostrar(ListView caja)
        {
            caja.Items.Clear();
            NodoPilaLibros t = _tope;
            while (t != null) 
            {
                ListViewItem datos = new ListViewItem
                    (Convert.ToString(t.numero));
                datos.SubItems.Add(t.nombre);
                caja.Items.Add(datos);
                t = t.Siguiente;
            }
        }
    }
}
