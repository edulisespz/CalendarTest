using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarTest
{
    class Cita
    {
        public string nombre;
        public DateTime fechaCita;


        public Cita()
        {

        }

        public Cita(Cita citaObj)
        {
            this.nombre = citaObj.nombre;
            this.fechaCita = citaObj.fechaCita;
        }
        
    }
}
