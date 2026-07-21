
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pago {

    public Pago() {
    }

    private int idPago;

    private DateTime fechaPago;

    private decimal monto;

    private MetodoPago metodo;

    private string numeroTransaccion;

    public void Attribute2;

    public Membresia membresia;

    public Empleado empleado;

    public Comprobante comprobante;

    /// <summary>
    /// @return
    /// </summary>
    public bool validarMonto() {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Comprobante generarComprobante() {
        // TODO implement here
        return null;
    }

}