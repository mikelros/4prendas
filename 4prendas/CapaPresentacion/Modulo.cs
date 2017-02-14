using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public class Modulo
    {
        public static Negocio miNegocio = new Negocio();
        public static Empleado empleadoActual;
        public static List<Empleado> empleados = miNegocio.getEmpleados();
    }
}
