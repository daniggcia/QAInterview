
# QA.Interview – Test Automation Project

Proyecto de automatización de pruebas UI y API para el sitio [Practice Software Testing](https://practicesoftwaretesting.com/), usando .NET, Selenium, SpecFlow y más.

## 📁 Estructura del Proyecto

```
QA.Interview/
├── Features/                   # Archivos .feature con los escenarios en Gherkin
│   ├── CheckoutLogin.feature
│   └── HandTools.feature
│
├── Pages/                     # Page Object Models
│   └── LoginPage.cs
│
├── StepDefinitions/          # Definiciones de los pasos en SpecFlow
│   └── CheckoutSteps.cs
│
├── Hooks/                    # Hooks de SpecFlow (si los hay)
│
├── app.config                # Configuraciones de Selenium, si aplica
├── QA.Interview.csproj       # Proyecto .NET
└── README.md                 # Este archivo
```

## 🛠Tecnologías utilizadas

Lenguaje: C# (.NET 8.0)
Framework de testing: SpecFlow (BDD)
Automatización Web: Selenium WebDriver
Navegador: Chrome
IDE: JetBrains Rider
Control de versiones: Git + GitHub

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- [SpecFlow](https://specflow.org/)
- [Selenium WebDriver](https://www.selenium.dev/)
- [ChromeDriver](https://chromedriver.chromium.org/)
- [Gherkin](https://cucumber.io/docs/gherkin/)
- [JetBrains Rider](https://www.jetbrains.com/rider/) (IDE)


## Funcionalidades clave

- Navegación dinámica por el menú de categorías
- Selección y compra de productos
- Validación de errores en login
- Esperas explícitas para sincronización
- Manejador de errores y mensajes condicionales para mejorar trazabilidad

## Buenas prácticas aplicadas

- Uso de Page Object Model
- Separación de concerns
- Sin sleeps: sincronización por WebDriverWait
- Selectores CSS claros y mantenibles

## Consideraciones

- Es necesario tener **Chrome instalado**.
- Asegúrate de tener la versión correcta de `chromedriver` en tu entorno.
- La URL de prueba es pública, pero puede cambiar sin previo aviso.

## Pendientes o mejoras futuras

- Implementar pruebas para filtros
- Añadir validaciones visuales (por ejemplo, capturas en fallos)
- Añadir pipeline de integración continua (GitHub Actions o Azure DevOps)

### Instalación y ejecución
- Clonar el proyecto:
  git clone https://github.com/daniggcia/QAInterview.git

- Restaurar dependencias:
  dotnet restore

- Ejecutar los tests:
  dotnet test

### Consideraciones técnicas

Se evita el uso de Thread.Sleep(), priorizando buenas prácticas con esperas explícitas.
Se trabaja con selectores robustos (data-test, formcontrolname, etc.) para minimizar la fragilidad.
En caso de conflictos al realizar git pull, se resolvieron conflictos manualmente con rebase.


## 👤 Autor

Daniel – QA Automation Engineer 
daniggcia@hotmail.com

