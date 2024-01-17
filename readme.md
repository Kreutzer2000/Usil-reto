# Hangman Game in C#

Este proyecto es una implementación del juego del ahorcado en C#. Incluye pruebas unitarias y generación de reportes de cobertura de código.

## Requisitos

Para ejecutar este proyecto y sus pruebas, necesitas:

- .NET SDK (Version 6.0 o superior)
- ReportGenerator (para generar reportes de cobertura de código)

## Configuración del Proyecto

Para configurar el proyecto y ejecutar las pruebas, sigue estos pasos:

1. Clona el repositorio:

git clone https://github.com/12joan/hangman

2. Navega al directorio del proyecto:

cd [directorio del proyecto]

## Ejecución de Pruebas Unitarias

Para ejecutar las pruebas unitarias, usa el siguiente comando en la línea de comandos:

dotnet test

## Generación de Reportes de Cobertura de Código

Para generar un reporte de cobertura de código, sigue estos pasos:

1. Ejecuta las pruebas con recopilación de datos de cobertura:

dotnet test --collect:"XPlat Code Coverage"

2. Genera el reporte de cobertura con ReportGenerator:

reportgenerator "-reports:[Ruta al archivo .xml de cobertura]" "-targetdir:[Directorio de destino para el reporte]" -reporttypes:Html

## Notas Adicionales

- La cobertura de código está calculada con base en las pruebas unitarias disponibles. La meta es alcanzar o superar el 95% de cobertura.
- Algunas partes del código pueden no estar completamente cubiertas por pruebas unitarias debido a su naturaleza (como interacciones con la consola). En estos casos, se recomienda documentar las razones de la cobertura no completa en este archivo README.

## Uso Correcto del .gitignore

Este proyecto utiliza un archivo `.gitignore` configurado para excluir archivos específicos de .NET y archivos generados durante la compilación y ejecución de pruebas.
