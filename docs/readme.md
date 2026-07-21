# Documentación del proyecto MDD con StarUML

## Descripción

Esta carpeta contiene el informe académico y los recursos utilizados en la exposición sobre Desarrollo Dirigido por Modelos (MDD) mediante StarUML. La práctica parte de un modelo UML del subsistema de gestión de gimnasio y documenta su transformación en código C#.

## Contenido de la carpeta

| Archivo o carpeta | Descripción |
|---|---|
| `figuras/` | Contiene los diagramas e imágenes incorporados en el informe LaTeX. |
| `Esqueleto_Informe_MDD_StarUML_Gimnasio.pdf` | Versión inicial empleada como estructura base del informe. |
| `Fundamentacion_MDE_MDA_MDD.tex` | Fundamentación teórica sobre MDE, MDA, MDD, CIM, PIM, PSM, M2M y M2T. |
| `Informe_MDD_StarUML.tex` | Archivo fuente principal y editable del informe. |
| `Informe_MDD_StarUML.pdf` | Versión completa del informe compilada en formato PDF. |
| `Informe_MDD_StarUML_Reducido.pdf` | Versión del informe con tamaño reducido para facilitar su consulta o envío. |
| `referencias.bib` | Base de datos bibliográfica utilizada para gestionar las citas y referencias del informe. |
| `README.md` | Descripción del contenido y guía básica de compilación de esta carpeta. |

## Documento principal

El archivo fuente principal es:

```text
Informe_MDD_StarUML.tex
```

Su versión compilada corresponde a:

```text
Informe_MDD_StarUML.pdf
```

Por su parte, `Fundamentacion_MDE_MDA_MDD.tex` constituye un archivo complementario centrado exclusivamente en los fundamentos conceptuales del enfoque dirigido por modelos.

## Requisitos para la compilación

Para compilar el informe se recomienda disponer de:

- MiKTeX o TeX Live.
- TeXstudio, Overleaf u otro editor compatible con LaTeX.
- Los paquetes LaTeX declarados en el preámbulo del documento.
- La carpeta `figuras/` y el archivo `referencias.bib` dentro de `docs/`.

## Compilación del informe

Desde TeXstudio, se debe abrir `Informe_MDD_StarUML.tex` y ejecutar la opción de compilación. Si las referencias no aparecen en el primer intento, debe procesarse la bibliografía y compilar nuevamente el documento.

También puede utilizarse el siguiente comando desde la carpeta `docs/`:

```bash
latexmk -pdf Informe_MDD_StarUML.tex
```

Este proceso genera o actualiza `Informe_MDD_StarUML.pdf` y ejecuta las etapas necesarias para resolver referencias cruzadas y bibliográficas.

## Organización recomendada

```text
docs/
├── figuras/
├── Esqueleto_Informe_MDD_StarUML_Gimnasio.pdf
├── Fundamentacion_MDE_MDA_MDD.tex
├── Informe_MDD_StarUML.tex
├── Informe_MDD_StarUML.pdf
├── Informe_MDD_StarUML_Reducido.pdf
├── referencias.bib
└── README.md
```

## Observación

Para conservar la trazabilidad del trabajo, las modificaciones deben realizarse sobre los archivos `.tex` y no directamente sobre los PDF. Asimismo, las figuras utilizadas en el informe deben mantenerse en la carpeta `figuras/` con nombres claros y consistentes.
