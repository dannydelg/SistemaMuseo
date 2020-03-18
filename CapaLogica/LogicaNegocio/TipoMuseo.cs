using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    class TipoMuseo
    {
        private int tipoMuseoId;
        private string tipoMuseoDescripcion;
        private char tipoMuseoEstado;

      

        public TipoMuseo()
        {
        }

        public TipoMuseo(int tipoMuseoId, string tipoMuseoDescripcion, char tipoMuseoEstado)
        {
            this.tipoMuseoId = tipoMuseoId;
            this.tipoMuseoDescripcion = tipoMuseoDescripcion;
            this.tipoMuseoEstado = tipoMuseoEstado;
        }

        public int TipoMuseoId { get => tipoMuseoId; set => tipoMuseoId = value; }
        public string TipoMuseoDescripcion { get => tipoMuseoDescripcion; set => tipoMuseoDescripcion = value; }
        public char TipoMuseoEstado { get => tipoMuseoEstado; set => tipoMuseoEstado = value; }
    }


}
