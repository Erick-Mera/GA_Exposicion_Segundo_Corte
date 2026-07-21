
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Membresia {

    public Membresia() {
    }

    private int idMembresia;

    private DateTime fechaInicio;

    private DateTime fechaFin;

    private EstadoMembresia estado;

    public Cliente cliente;

    public PlanMembresia plan;

    public HashSet<Pago> pagos;

    /// <summary>
    /// @param fechaActual 
    /// @return
    /// </summary>
    public bool estaVigente(DateTime fechaActual) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param fechaActual 
    /// @return
    /// </summary>
    public int calcularDiasRestantes(DateTime fechaActual) {
        // TODO implement here
        return 0;
    }

    /// <summary>
    /// @param fechaInicio 
    /// @param plan 
    /// @return
    /// </summary>
    public void renovar(DateTime fechaInicio, PlanMembresia plan) {
        // TODO implement here
        return null;
    }

}