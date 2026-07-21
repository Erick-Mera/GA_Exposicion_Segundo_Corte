
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio{
    public class Cliente : Persona {

        public Cliente() {
        }

        private DateTime fechaRegistro;

        private bool activo;

        public HashSet<Membresia> membresias;

        /// <summary>
        /// @return
        /// </summary>
        public Membresia consultarMembresiaActiva() {
            // TODO implement here
            return null;
        }

        public void desactivar() {
            // TODO implement here
        }

    }
}