# QAInterview
El proyecto QA Interview está diseñado para evaluar las habilidades del candidato y forma parte del proceso de selección para el equipo de QA Automation. En este proyecto, se debe implementar una serie de ejercicios utilizando Selenium WebDriver.
# QA.Interview

Este proyecto contiene un conjunto de pruebas automatizadas desarrolladas con .NET, SpecFlow y Selenium WebDriver. Su objetivo es validar funcionalidades clave de un e-commerce de herramientas (ToolShop Demo) mediante pruebas de UI y validaciones de login en el proceso de checkout.

## Tecnologías utilizadas

- .NET 8.0
- SpecFlow
- Selenium WebDriver
- xUnit
- Rider o Visual Studio
- ChromeDriver

## Estructura del proyecto

- **Features**: archivos .feature con escenarios en Gherkin
- **StepDefinitions**: implementación de pasos en C#
- **Pages**: Page Objects con los elementos y acciones
- **Hooks**: configuración global de pruebas

## Cómo ejecutar las pruebas

1. Clona el repositorio
2. Restaura los paquetes
dotnet restore

markdown
Copiar
Editar
3. Ejecuta las pruebas
dotnet test

markdown
Copiar
Editar

## Escenarios automatizados

- Login fallido durante checkout con credenciales inválidas
- Navegación y selección de producto en Power Tools
- Añadir producto al carrito
- Proceso de compra con errores de validación

## Notas

- Asegúrate de tener Chrome actualizado
- Usa un entorno limpio para evitar conflictos de versiones
- Si necesitas cambiar el navegador o el entorno, modifica los hooks o los PageObjects
