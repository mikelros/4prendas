using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Recogida
    {
        private int idRecogida;
        private DateTime fechaRecogida;
        private int empleadoId;
        private int cantidadProductos;
        private int personaId;

        public Recogida() { }

        public Recogida(DateTime fechaRecogida, int empleadoId, int cantidadProductos)
        {
            this.fechaRecogida = fechaRecogida;
            this.empleadoId = empleadoId;
            this.cantidadProductos = cantidadProductos;
        }

        public Recogida(DateTime fechaRecogida, int empleadoId, int cantidadProductos, int personaId)
        {
            this.fechaRecogida = fechaRecogida;
            this.empleadoId = empleadoId;
            this.cantidadProductos = cantidadProductos;
            this.personaId = personaId;
        }

        public Recogida(int id, DateTime fechaRecogida, int empleadoId, int cantidadProductos, int personaId)
        {
            this.idRecogida = id;
            this.fechaRecogida = fechaRecogida;
            this.empleadoId = empleadoId;
            this.cantidadProductos = cantidadProductos;
            this.personaId = personaId;
        }

        public int IdRecogida
        {
            get
            {
                return idRecogida;
            }
            set
            {
                idRecogida = value;
            }
        }

        public DateTime FechaRecogida
        {
            get
            {
                return fechaRecogida;
            }
            set
            {
                fechaRecogida = value;
            }
        }

        public int EmpleadoId
        {
            get
            {
                return empleadoId;
            }
            set
            {
                empleadoId = value;
            }
        }

        public int CantidadProductos
        {
            get
            {
                return cantidadProductos;
            }
            set
            {
                cantidadProductos = value;
            }
        }

        public int PersonaId
        {
            get
            {
                return personaId;
            }
            set
            {
                personaId = value;
            }
        }
    }
}
