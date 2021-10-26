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
        public NodoPilaLibros()
        {
            numero = 0;
            nombre = "";
            fecha = "";
        }
        public NodoPilaLibros(int num, string nomb, string f)
        {
            numero = num;
            nombre = nomb;
            fecha = f;
        }
    }
}
