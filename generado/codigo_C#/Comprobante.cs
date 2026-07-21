
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Comprobante {

    public Comprobante() {
    }

    private int idComprobante;

    private string numero;

    private DateTime fechaEmision;

    private decimal subtotal;

    private decimal iva;

    private decimal total;

    public Pago pago;

    /// <summary>
    /// @return
    /// </summary>
    public decimal calcularTotal() {
        // TODO implement here
        return 0.0M;
    }

    /// <summary>
    /// @return
    /// </summary>
    public string obtenerResumen() {
        // TODO implement here
        return "";
    }

}