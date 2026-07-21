
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Empleado : Persona {

    public Empleado() {
    }

    private string cargo;

    private string usuario;

    private bool activo;

    public HashSet<Pago> pagosRegistrados;

    /// <summary>
    /// @param membresia 
    /// @param monto 
    /// @return
    /// </summary>
    public Pago registrarPago(Membresia membresia, decimal monto) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param cliente 
    /// @param plan 
    /// @return
    /// </summary>
    public Membresia asignarMembresia(Cliente cliente, PlanMembresia plan) {
        // TODO implement here
        return null;
    }

}