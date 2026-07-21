
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Persona {

    public Persona() {
    }

    private int idPersona;

    private string cedula;

    private string nombres;

    private string apellidos;

    private string telefono;

    private string correo;

    /// <summary>
    /// @param telefono 
    /// @param correo 
    /// @return
    /// </summary>
    public void actualizarDatos(string telefono, string correo) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public string obtenerNombreCompleto() {
        // TODO implement here
        return "";
    }

    public void Operation3() {
        // TODO implement here
    }

}