using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasArregloFormulario
{
    class NodoPilaLibros
    {
        public int numero;
        public string nombre;
        public NodoPilaLibros siguiente;

        public NodoPilaLibros Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
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
        public NodoPilaLibros()
        {
            numero = 0;
            nombre = "";
            siguiente = null;
        }
        public NodoPilaLibros(int num, string nomb)
        {
            numero = num;
            nombre = nomb;
            siguiente = null;
        }
    }
}
