# Exposición MDD con StarUML: generación de código a partir de modelos UML

## Información académica

- **Universidad:** Universidad Técnica Estatal de Quevedo
- **Carrera:** Ingeniería en Software
- **Asignatura:** Ingeniería de Requisitos (ISR-401)
- **Docente:** Ing. Gleiston Guerrero Ulloa, PhD.
- **Periodo académico:** 2026-2027 PPA
- **Paralelo:** [COLOCAR PARALELO]
- **Herramienta CASE:** StarUML
- **Lenguaje objetivo:** C#

## Descripción del proyecto

Este repositorio contiene los modelos UML, archivos de configuración, código generado, evidencias, informe LaTeX y diapositivas correspondientes a la exposición-demostración sobre desarrollo dirigido por modelos o Model-Driven Development (MDD).

La demostración utiliza StarUML como herramienta CASE para construir un modelo UML y generar automáticamente código fuente C#. El proceso comprende el modelado, configuración del generador, generación del código, compilación, ejecución y regeneración controlada.

## Proyecto Fin de Curso

El Proyecto Fin de Curso corresponde a un **Sistema de Gestión para un Gimnasio**, diseñado para apoyar el control de clientes, membresías, pagos, productos, inventario, rutinas y demás operaciones relacionadas con la administración del establecimiento.

## Subsistema modelado

Para la demostración se seleccionó el subsistema de **gestión de clientes, membresías y pagos** del Sistema de Gestión para un Gimnasio. Este subsistema concentra los procesos necesarios para registrar a los clientes, administrar los planes disponibles, asignar y renovar membresías, controlar su vigencia y registrar los pagos realizados.

### Procesos principales

El subsistema comprende los siguientes procesos:

- Registrar y actualizar la información de los clientes.
- Crear y consultar los planes de membresía disponibles.
- Asignar y renovar membresías de acuerdo con el plan seleccionado.
- Consultar el estado y la fecha de vencimiento de una membresía.
- Registrar los pagos efectuados por los clientes.
- Generar o asociar un comprobante al pago registrado.

El modelo UML estará conformado por clases relevantes del dominio, como `Cliente`, `Membresia`, `PlanMembresia`, `Pago`, `Comprobante` y `Empleado`. Estas clases contendrán atributos tipados, operaciones con firma completa, visibilidad, relaciones y cardinalidades coherentes con el funcionamiento del sistema.

A partir de este modelo se generará automáticamente código fuente C# mediante StarUML y posteriormente se verificará su compilación, ejecución y regeneración controlada.
## Integrantes y responsabilidades

| Integrante | Responsabilidad principal |
|---|---|
| Díaz Pontón Steven Santiago | Fundamentación teórica y referencias |
| Escudero Plaza María del Rosario | Construcción y validación del modelo UML |
| Mera Arias Erick Jhair | Configuración del generador y generación de código |
| Mesías Quijije Jhon Alexander | Compilación, roundtrip, evidencias y exposición |

Las responsabilidades señaladas representan el liderazgo de cada fase. Todos los integrantes deben conocer el funcionamiento completo del proyecto y participar en la demostración.

## Herramientas y versiones

| Herramienta | Versión utilizada | Finalidad |
|---|---:|---|
| StarUML | [VERSIÓN EXACTA] | Construcción del modelo UML |
| Extensión C# | [VERSIÓN EXACTA] | Generación de código C# |
| Visual Studio | [VERSIÓN EXACTA] | Compilación y ejecución |
| .NET SDK | [VERSIÓN EXACTA] | SDK y runtime de C# |
| Git | [VERSIÓN EXACTA] | Control de versiones |
| MiKTeX/TeX Live | [VERSIÓN EXACTA] | Compilación del informe LaTeX |
| Windows | Windows 11 de 64 bits | Sistema operativo probado |

> Las versiones deberán actualizarse con los valores exactos instalados en el equipo utilizado para la demostración.

## Requisitos previos

Para reproducir el proyecto se requiere:

- Git.
- StarUML.
- Extensión de generación de código C# para StarUML.
- .NET SDK.
- Visual Studio o Visual Studio Code.
- MiKTeX o TeX Live.
- Compilador `pdflatex`, `xelatex` o `lualatex`.
- Sistema operativo Windows 11 de 64 bits o compatible.

## Estructura del repositorio

```text
GA_Exposicion_Segundo_Corte/
├── README.md
├── docs/
│   ├── informe.tex
│   ├── informe.pdf
│   ├── referencias.bib
│   └── figuras/
├── modelo/
│   ├── proyecto_staruml.mdj
│   └── perfiles/
├── plantillas/
│   └── configuracion_generador.md
├── generado/
│   └── codigo-csharp/
├── verificacion/
│   └── proyecto-prueba/
├── evidencias/
│   ├── capturas/
│   └── video-demo.md
└── exposicion/
    └── diapositivas.pdf
```

## Instrucciones para clonar el repositorio

Abrir una terminal y ejecutar:

```bash
git clone https://github.com/Erick-Mera/GA_Exposicion_Segundo_Corte.git
cd GA_Exposicion_Segundo_Corte
```

## Instrucciones para abrir el modelo

1. Instalar StarUML versión `[VERSIÓN]`.
2. Instalar la extensión C# versión `[VERSIÓN]`.
3. Abrir StarUML.
4. Seleccionar `File > Open`.
5. Abrir el archivo:

```text
modelo/proyecto_staruml.mdj
```

6. Localizar el diagrama de clases del subsistema seleccionado.
7. Verificar las clases, atributos, operaciones, relaciones y cardinalidades.

## Instrucciones para generar el código

1. Abrir el archivo nativo `.mdj`.
2. Seleccionar el modelo o paquete correspondiente.
3. Ejecutar el comando de generación de la extensión C#.
4. Seleccionar como directorio de salida:

```text
generado/codigo-csharp/
```

5. Ejecutar la generación.
6. Comprobar que se crearon los archivos `.cs`.
7. Revisar el registro o resultado de la generación.

La configuración empleada está documentada en:

```text
plantillas/configuracion_generador.md
```

## Compilación y ejecución del código

El código generado se verifica mediante el proyecto ubicado en:

```text
verificacion/proyecto-prueba/
```

Para compilar y ejecutar:

```bash
cd verificacion/proyecto-prueba
dotnet restore
dotnet build
dotnet run
```

La compilación debe finalizar sin errores y ejecutar al menos una unidad mínima demostrable.

## Regeneración controlada o roundtrip

Para cerrar el ciclo MDD se realizará un cambio significativo en el modelo UML. Posteriormente, se regenerará el código y se verificará que el cambio aparezca en el archivo C# correspondiente.

El cambio seleccionado será:

- **Elemento modificado:** [CLASE, OPERACIÓN, ATRIBUTO O RELACIÓN].
- **Estado inicial:** [DESCRIBIR].
- **Cambio realizado:** [DESCRIBIR].
- **Resultado esperado:** [DESCRIBIR].

Las capturas del antes y después se encuentran en:

```text
evidencias/capturas/
```

## Compilación del informe LaTeX

El archivo principal del informe es:

```text
docs/informe.tex
```

Para compilarlo con `pdflatex` y BibTeX:

```bash
cd docs
pdflatex informe.tex
bibtex informe
pdflatex informe.tex
pdflatex informe.tex
```

Este procedimiento genera:

```text
docs/informe.pdf
```

Si el equipo utiliza `xelatex`, `lualatex` o `biber`, estos comandos deberán actualizarse con el procedimiento realmente probado.

## Video de respaldo

El video de respaldo de la generación, compilación y regeneración controlada se encuentra disponible en:

[COLOCAR ENLACE DEL VIDEO]

También puede consultarse en:

```text
evidencias/video-demo.md
```

## Evidencia de participación

La participación individual se evidencia mediante:

- Commits diferenciados por integrante.
- Archivos aportados por cada estudiante.
- Responsabilidades declaradas.
- Participación durante la exposición.
- Captura de `Insights > Contributors`.
- Enlaces a los commits incluidos en el informe LaTeX.

## Limitaciones identificadas

- [LIMITACIÓN DEL GENERADOR 1].
- [LIMITACIÓN DEL GENERADOR 2].
- [LIMITACIÓN DEL ROUNDTRIP].
- [ELEMENTOS QUE REQUIEREN IMPLEMENTACIÓN MANUAL].

## Referencias

Las referencias académicas, estándares y documentación técnica utilizada se encuentran en:

```text
docs/referencias.bib
```
