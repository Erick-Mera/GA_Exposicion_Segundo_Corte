# Configuración del generador de código C#

## Objetivo

En primer lugar, este archivo documenta la configuración empleada para transformar el modelo UML del subsistema del gimnasio en código fuente C# mediante la extensión instalada en StarUML.

## Elemento seleccionado para la generación

Asimismo, la generación se ejecutó sobre el paquete UML `Gimnasio.Dominio`, debido a que este agrupa las clases, enumeraciones, atributos, operaciones y relaciones que forman el modelo de dominio.

## Ajustes realizados en la plantilla

Por otra parte, fue necesario revisar el archivo `code-generator.js` de la extensión para que el código producido utilizara expresiones válidas en C#. Los principales ajustes fueron los siguientes:

1. **Corrección del valor booleano:** se reemplazó `False` por `false`, porque C# distingue entre mayúsculas y minúsculas.
2. **Métodos sin retorno:** se eliminó `return null;` de los métodos cuyo tipo de retorno es `void`.
3. **Valores de fecha:** se configuró `default(DateTime)` como valor inicial para los métodos que deben devolver un objeto de tipo `DateTime` sin una implementación definitiva.
4. **Valores predeterminados:** se conservaron valores compatibles con cada tipo, como `false` para `bool`, `0` para `int` y `null` para tipos de referencia cuando corresponde.
5. **Estructura de operaciones:** los métodos generados mantienen la firma definida en UML e incluyen un comentario `TODO` para indicar que la lógica de negocio debe implementarse posteriormente.

## Procedimiento de generación

Posteriormente, el procedimiento aplicado fue el siguiente:

1. Abrir el archivo nativo `.mdj` en StarUML.
2. Comprobar que las clases y enumeraciones estén contenidas en `Gimnasio.Dominio`.
3. Seleccionar el paquete en el panel **Model Explorer**.
4. Ejecutar la opción de generación de código C# de la extensión.
5. Elegir el directorio de salida destinado al código generado.
6. Verificar que se hayan producido siete clases y dos enumeraciones.
7. Incorporar los nueve archivos `.cs` al proyecto de verificación y compilar la solución.

## Política de sobrescritura

Además, los archivos generados se consideran artefactos reemplazables. Antes de volver a ejecutar el generador se debe conservar una copia de cualquier implementación manual, porque una nueva generación puede sobrescribir el contenido existente.

En consecuencia, los cambios estructurales deben realizarse primero en el modelo UML. La lógica de negocio debe mantenerse separada o respaldarse antes de regenerar el código.

## Resultado

Finalmente, la configuración permitió obtener nueve archivos C# correspondientes a siete clases y dos enumeraciones. Al integrarlos en el proyecto de verificación, la solución compiló sin errores.
