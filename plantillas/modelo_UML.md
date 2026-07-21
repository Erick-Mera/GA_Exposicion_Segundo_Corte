# Mapeo del modelo UML a código C#

## Propósito

En primer lugar, este documento describe las correspondencias utilizadas para transformar los elementos del modelo UML del subsistema del gimnasio en estructuras equivalentes de C#.

## Mapeo de elementos estructurales

Asimismo, la transformación aplica las siguientes correspondencias generales:

| Elemento UML | Representación en C# |
|---|---|
| Paquete | Agrupación lógica del código generado |
| Clase | Declaración `class` |
| Enumeración | Declaración `enum` |
| Atributo | Campo tipado dentro de la clase |
| Operación | Método con parámetros y tipo de retorno |
| Parámetro | Parámetro formal del método |
| Generalización | Herencia mediante `:` |
| Asociación simple | Referencia a un objeto |
| Asociación con multiplicidad múltiple | Colección genérica, como `HashSet<T>` |

## Visibilidad

Por otra parte, los símbolos de visibilidad definidos en UML se representan de la siguiente manera:

| Visibilidad UML | C# |
|---|---|
| `+` Pública | `public` |
| `-` Privada | `private` |
| `#` Protegida | `protected` |

## Tipos de datos

Además, los tipos principales empleados en el modelo se convierten de acuerdo con la siguiente tabla:

| Tipo en UML | Tipo en C# |
|---|---|
| `Integer` o `int` | `int` |
| `String` | `string` |
| `Boolean` | `bool` |
| `DateTime` | `DateTime` |
| `void` | `void` |

## Clases y enumeraciones generadas

En particular, el modelo produce los siguientes archivos:

| Elemento UML | Archivo C# | Tipo |
|---|---|---|
| `Persona` | `Persona.cs` | Clase |
| `Cliente` | `Cliente.cs` | Clase |
| `Empleado` | `Empleado.cs` | Clase |
| `PlanMembresia` | `PlanMembresia.cs` | Clase |
| `Membresia` | `Membresia.cs` | Clase |
| `Pago` | `Pago.cs` | Clase |
| `Comprobante` | `Comprobante.cs` | Clase |
| `EstadoMembresia` | `EstadoMembresia.cs` | Enumeración |
| `MetodoPago` | `MetodoPago.cs` | Enumeración |

## Relaciones principales

De igual manera, las relaciones del modelo se reflejan en el código mediante herencia, referencias y colecciones:

- `Cliente` y `Empleado` especializan a `Persona`.
- `Cliente` mantiene una colección de membresías.
- `Membresia` conserva referencias al cliente y al plan contratado.
- `Membresia` mantiene una colección de pagos.
- `Empleado` puede relacionarse con los pagos registrados.
- `Pago` se relaciona con su comprobante y con el método de pago correspondiente.

## Operaciones

Posteriormente, cada operación UML se transforma en una firma de método C#. Por ejemplo, la operación UML:

```text
+suspender(motivo: string): void
```

se representa en C# como:

```csharp
public void suspender(string motivo)
{
    // TODO implement here
}
```

## Alcance de la transformación

Finalmente, la generación automática produce la estructura del código: clases, enumeraciones, atributos, relaciones, operaciones, parámetros y tipos de retorno. Sin embargo, no desarrolla las reglas de negocio internas, por lo que los bloques marcados con `TODO` deben implementarse posteriormente.
