using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EventoError: EventArgs
    {
        public string message = "";

        public EventoError(string message)
        {
            this.message = message;
        }

        public string Message { get { return message; } }
    }
}
