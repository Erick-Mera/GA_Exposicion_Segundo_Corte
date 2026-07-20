# Generación de código C# desde modelos UML con StarUML

Repositorio de la exposición-demostración del ciclo de desarrollo dirigido por modelos (MDD), aplicado al subsistema de clientes, membresías y pagos del **Sistema de Gestión para un Gimnasio**.

## Información académica

- **Universidad:** Universidad Técnica Estatal de Quevedo
- **Carrera:** Ingeniería en Software
- **Asignatura:** Ingeniería de Requerimientos
- **Docente:** Ing. Gleiston Guerrero Ulloa, PhD.
- **Periodo académico:** 2026-2027 PPA
- **Paralelo:** 4.º Software A
- **Proyecto Fin de Curso:** Sistema de Gestión para un Gimnasio
- **Herramienta MDD:** StarUML
- **Lenguaje objetivo:** C#
- **Repositorio:** <https://github.com/Erick-Mera/GA_Exposicion_Segundo_Corte>

## Descripción

El proyecto demuestra cómo un modelo UML puede utilizarse como fuente para generar código C#. El proceso comprende la construcción y validación del modelo, la configuración del generador, la creación automática de archivos `.cs`, su compilación y ejecución en .NET y un roundtrip controlado para comprobar la trazabilidad entre el modelo y el código.

La demostración no abarca todo el sistema del gimnasio. Se utiliza un subsistema representativo relacionado con clientes, planes, membresías, pagos y comprobantes.

## Alcance del subsistema

El modelo contiene siete clases y dos enumeraciones:

- `Persona`
- `Cliente`
- `Empleado`
- `PlanMembresia`
- `Membresia`
- `Pago`
- `Comprobante`
- `EstadoMembresia`
- `MetodoPago`

Los elementos incorporan atributos tipados, operaciones con firma completa, visibilidad, herencia, asociaciones, composición y multiplicidades. El modelo fue validado en StarUML con el resultado **Validation Results - No Errors**.

## Integrantes y distribución de responsabilidades

| Integrante | Responsabilidad asignada | Participación en la demostración |
|---|---|---|
| Díaz Pontón Steven Santiago | Fundamentación MDE, MDA y MDD; revisión de referencias | Apertura del modelo y explicación general del diagrama |
| Escudero Plaza María del Rosario | Revisión del modelo UML y de sus relaciones | Recorrido por el modelo, validación y selección del paquete |
| Mera Arias Erick Jhair | Configuración y ajuste del generador C#; verificación técnica | Generación de archivos, compilación y ejecución en Visual Studio |
| Mesías Quijije Jhon Alexander | Trazabilidad, evidencias y cierre del ciclo | Cambio del modelo, regeneración y comprobación del roundtrip |

## Entorno utilizado

| Componente | Versión o configuración |
|---|---|
| Sistema operativo | Windows 11 de 64 bits |
| StarUML | 7.1.0, modo de prueba |
| Extensión C# para StarUML | 0.9.7 |
| Visual Studio | Community 2026, versión 18.8.0 |
| .NET SDK | 10.0.302 |
| Framework de destino | `net10.0` |
| Compilación del informe | PdfLaTeX + BibTeX |

## Resultados obtenidos

- Modelo UML validado sin errores en StarUML.
- Siete clases y dos enumeraciones transformadas en nueve archivos C#.
- Proyecto de verificación recompilado correctamente con cero errores.
- Ejecución de una unidad mínima demostrable con código de salida `0`.
- Roundtrip controlado mediante la operación `suspender(motivo: string): void`.
- Regeneración confirmada mediante la aparición del método `suspender` en `Membresia.cs`.
- El generador no informó un tiempo propio de generación. Los nueve archivos quedaron registrados con la misma marca de tiempo.
- Visual Studio registró aproximadamente `3,888 s` para la recompilación completa y `0,061 s` para una compilación incremental posterior.

## Estructura del repositorio

```text
GA_Exposicion_Segundo_Corte/
|-- README.md
|-- docs/
|   |-- Informe_MDD_StarUML_Actualizado.tex
|   |-- Informe_MDD_StarUML_Actualizado.pdf
|   |-- referencias.bib
|   `-- figuras/
|-- modelo/
|   `-- modelo_subsistema_gimnasio_final.mdj
|-- plantillas/
|   |-- code-generator.js
|   |-- configuracion_generador.md
|   `-- mapeo_uml_csharp.md
|-- generado/
|   |-- codigo-csharp/
|   `-- roundtrip/
|       |-- antes/
|       `-- despues/
|-- verificacion/
|   `-- VerificacionGimnasioLimpio/
|-- evidencias/
|   |-- capturas/
|   `-- video-demo.md
`-- exposicion/
    `-- diapositivas.pdf
```

## Clonar el repositorio

```bash
git clone https://github.com/Erick-Mera/GA_Exposicion_Segundo_Corte.git
cd GA_Exposicion_Segundo_Corte
```

## Abrir y validar el modelo

1. Instalar StarUML 7.1.0.
2. Instalar la extensión C# 0.9.7 desde `Tools > Extension Manager`.
3. Abrir StarUML y seleccionar `File > Open`.
4. Abrir el archivo:

```text
modelo/modelo_subsistema_gimnasio_final.mdj
```

5. Abrir el diagrama `GestionClientesMembresiasPagos`.
6. Comprobar las clases, enumeraciones, atributos, operaciones, relaciones y multiplicidades.
7. Ejecutar la validación y comprobar el mensaje `Validation Results - No Errors`.

## Generar el código C#

1. Abrir el modelo nativo `.mdj`.
2. Ejecutar el comando de generación de la extensión C#.
3. Seleccionar como modelo base el paquete `Gimnasio.Dominio`.
4. Seleccionar como directorio de salida:

```text
generado/codigo-csharp/
```

5. Ejecutar la generación.
6. Comprobar la creación de los nueve archivos `.cs`.

Archivos esperados:

```text
Cliente.cs
Comprobante.cs
Empleado.cs
EstadoMembresia.cs
Membresia.cs
MetodoPago.cs
Pago.cs
Persona.cs
PlanMembresia.cs
```

La configuración, la plantilla utilizada y las decisiones de mapeo se documentan en `plantillas/`.

## Correspondencia UML a C#

| Elemento del modelo | Resultado generado |
|---|---|
| Clase UML | Clase y archivo `.cs` |
| Atributo tipado | Campo con tipo C# |
| Operación UML | Método C# con parámetros y retorno |
| Generalización | Herencia de clase |
| Multiplicidad múltiple | Colección tipada |
| Enumeración UML | `enum` de C# |

## Compilar y ejecutar

El proyecto utilizado para verificar el código se encuentra en:

```text
verificacion/VerificacionGimnasioLimpio/
```

Desde una terminal:

```bash
cd verificacion/VerificacionGimnasioLimpio
dotnet restore
dotnet build
dotnet run
```

El resultado comprobado fue una recompilación correcta con cero errores y una ejecución terminada con código `0`. Pueden aparecer advertencias `CS0169` porque el generador crea campos privados que todavía no son utilizados por la unidad mínima de verificación.

`Program.cs` fue incorporado manualmente para instanciar y relacionar las clases. Los nueve archivos del dominio fueron generados por StarUML y se mantienen separados del código escrito manualmente.

## Roundtrip controlado

El cierre del ciclo se comprobó mediante un cambio significativo en la clase `Membresia`:

- **Estado inicial:** `Membresia.cs` no contenía una operación para suspender la membresía.
- **Cambio en StarUML:** se agregó `+suspender(motivo: string): void`.
- **Regeneración:** se ejecutó nuevamente el generador sobre el paquete `Gimnasio.Dominio`.
- **Resultado:** apareció `public void suspender(string motivo)` en `Membresia.cs`.
- **Verificación final:** el proyecto volvió a compilar con cero errores.

Las versiones del código anterior y posterior se conservan en:

```text
generado/roundtrip/antes/
generado/roundtrip/despues/
```

La extensión sobrescribe los archivos generados al regenerar. Por este motivo, la lógica escrita manualmente debe mantenerse separada o respaldarse antes de una nueva generación.

## Ajustes realizados al generador

La extensión C# 0.9.7 produjo inicialmente construcciones incompatibles con el compilador utilizado. Para garantizar una generación compilable se documentaron y aplicaron los siguientes ajustes en `code-generator.js`:

- Se sustituyó `False` por el literal válido de C# `false`.
- Los métodos declarados como `void` dejaron de generar `return null;`.
- Los retornos de tipo `DateTime` utilizan `default(DateTime)` en el esqueleto generado.
- La configuración del proyecto de verificación evita tratar las advertencias de nulabilidad como errores de compilación.

La plantilla ajustada debe conservarse en `plantillas/code-generator.js` para que el procedimiento sea reproducible.

## Limitaciones identificadas

- La extensión genera principalmente la estructura de clases, campos, relaciones y métodos; no implementa la lógica de negocio completa.
- StarUML genera archivos fuente, pero no crea por sí solo una solución ejecutable completa con `Program.cs` y archivo `.csproj`.
- La extensión C# 0.9.7 requirió ajustes de compatibilidad para producir código compilable con .NET 10.
- Las operaciones generadas contienen esqueletos o valores predeterminados que deben implementarse manualmente.
- La regeneración puede sobrescribir modificaciones hechas directamente en los archivos generados.
- El generador no mostró un log con el tiempo exacto de generación.

## Compilar el informe LaTeX

El archivo principal es:

```text
docs/Informe_MDD_StarUML_Actualizado.tex
```

Compilación probada:

```bash
cd docs
pdflatex Informe_MDD_StarUML_Actualizado.tex
bibtex Informe_MDD_StarUML_Actualizado
pdflatex Informe_MDD_StarUML_Actualizado.tex
pdflatex Informe_MDD_StarUML_Actualizado.tex
```

El resultado es `docs/Informe_MDD_StarUML_Actualizado.pdf`.

## Evidencias

Las capturas del entorno, validación, generación, archivos creados, compilación, ejecución y roundtrip se organizan en:

```text
evidencias/capturas/
```

## Video de respaldo

**Pendiente:** el video de respaldo de la generación, compilación y roundtrip se incorporará en `evidencias/video-demo.md` o se enlazará desde esta sección antes de la exposición.

La grabación deberá mostrar, como mínimo:

1. Apertura del modelo en StarUML.
2. Selección de `Gimnasio.Dominio`.
3. Generación de los nueve archivos C#.
4. Compilación y ejecución del proyecto.
5. Cambio en el modelo, regeneración y verificación del roundtrip.

## Informe y presentación

- Informe LaTeX: `docs/Informe_MDD_StarUML_Actualizado.tex`.
- Informe compilado: `docs/Informe_MDD_StarUML_Actualizado.pdf`.
- Referencias: `docs/referencias.bib`.
- Diapositivas finales: `exposicion/diapositivas.pdf`.

## Referencias

Las fuentes académicas, estándares y documentación técnica empleada están registradas en `docs/referencias.bib`.
