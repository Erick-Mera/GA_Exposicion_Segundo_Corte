# Modelo UML del subsistema del gimnasio

## Descripción

Este directorio contiene el modelo UML desarrollado en StarUML para representar el subsistema de clientes, planes, membresías y pagos del Sistema de Gestión para un Gimnasio.

El modelo fue elaborado como un artefacto procesable para la generación de código C# mediante la extensión C# de StarUML.

## Archivo principal

- `modelo_subsistema_gimnasio_final.mdj`: archivo nativo de StarUML que contiene el diagrama de clases y sus elementos UML.

## Clases del modelo

El modelo contiene siete clases:

1. `Persona`: clase base que reúne los datos comunes.
2. `Cliente`: representa a la persona que adquiere una membresía.
3. `Empleado`: representa al responsable de registrar los pagos.
4. `PlanMembresia`: define las características de los planes disponibles.
5. `Membresia`: relaciona al cliente con el plan contratado.
6. `Pago`: representa los pagos efectuados por una membresía.
7. `Comprobante`: contiene la información del comprobante generado por un pago.

## Enumeraciones

El modelo incluye dos enumeraciones:

- `EstadoMembresia`: limita los estados permitidos de una membresía, como activa, vencida, suspendida o cancelada.
- `MetodoPago`: define las formas de pago admitidas, como efectivo, tarjeta o transferencia.

## Relaciones principales

- `Cliente` y `Empleado` heredan los atributos y operaciones de `Persona`.
- Un cliente puede tener varias membresías.
- Cada membresía corresponde a un plan.
- Un plan puede estar asociado con varias membresías.
- Una membresía puede registrar varios pagos.
- Un empleado puede registrar varios pagos.
- Cada pago se relaciona con su respectivo comprobante.

## Validación y generación

Antes de generar el código, el modelo fue validado en StarUML sin presentar errores. Posteriormente, las siete clases y las dos enumeraciones fueron transformadas en nueve archivos de código C#.

El modelo contiene atributos tipados, operaciones, parámetros, tipos de retorno, visibilidades, relaciones y multiplicidades necesarias para realizar la transformación de modelo a texto (M2T).
