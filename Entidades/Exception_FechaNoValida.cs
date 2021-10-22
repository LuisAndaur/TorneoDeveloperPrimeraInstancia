using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Exception_FechaNoValida : Exception
    {
        private string mensajeError;
        public Exception_FechaNoValida() : base()
        {
            this.mensajeError = "Se ingresó un valor de fecha no vàlido, menor a 1";
        }

    }
}
