# Hangman Game in C#

Este proyecto es una implementaci�n del juego del ahorcado en C#. Incluye pruebas unitarias y generaci�n de reportes de cobertura de c�digo.

## Requisitos

Para ejecutar este proyecto y sus pruebas, necesitas:

- .NET SDK (Version 6.0 o superior)
- ReportGenerator (para generar reportes de cobertura de c�digo)

## Configuraci�n del Proyecto

Para configurar el proyecto y ejecutar las pruebas, sigue estos pasos:

1. Clona el repositorio:

git clone https://github.com/12joan/hangman

2. Navega al directorio del proyecto:

cd [directorio del proyecto]

## Ejecuci�n de Pruebas Unitarias

Para ejecutar las pruebas unitarias, usa el siguiente comando en la l�nea de comandos:

dotnet test

## Generaci�n de Reportes de Cobertura de C�digo

Para generar un reporte de cobertura de c�digo, sigue estos pasos:

1. Ejecuta las pruebas con recopilaci�n de datos de cobertura:

dotnet test --collect:"XPlat Code Coverage"

2. Genera el reporte de cobertura con ReportGenerator:

reportgenerator "-reports:[Ruta al archivo .xml de cobertura]" "-targetdir:[Directorio de destino para el reporte]" -reporttypes:Html

## Notas Adicionales

- La cobertura de c�digo est� calculada con base en las pruebas unitarias disponibles. La meta es alcanzar o superar el 95% de cobertura.
- Algunas partes del c�digo pueden no estar completamente cubiertas por pruebas unitarias debido a su naturaleza (como interacciones con la consola). En estos casos, se recomienda documentar las razones de la cobertura no completa en este archivo README.

## Uso Correcto del .gitignore

Este proyecto utiliza un archivo `.gitignore` configurado para excluir archivos espec�ficos de .NET y archivos generados durante la compilaci�n y ejecuci�n de pruebas.
