
# Comparación del roundtrip UML a C#

## Objetivo

Comprobar la trazabilidad entre el modelo UML elaborado en StarUML y el código C# generado automáticamente.

## Estado inicial

La clase `Membresia` contenía sus atributos, relaciones y operaciones originales. En esta versión todavía no se encontraba definida la operación para suspender una membresía.

El archivo correspondiente se conserva en:

`antes/Membresia.cs`

## Cambio realizado en el modelo

En StarUML se agregó a la clase `Membresia` la siguiente operación:

`+suspender(motivo: string): void`

La operación recibe el motivo de la suspensión como parámetro y no devuelve ningún valor.

## Regeneración del código

Después de modificar el modelo, se ejecutó nuevamente la generación de código C# sobre el paquete `Gimnasio.Dominio`.

Como resultado, en `Membresia.cs` apareció el siguiente método:

```csharp
public void suspender(string motivo)
{
    // TODO implement here
