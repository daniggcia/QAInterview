
# QA.Interview – Test Automation Project

Proyecto de automatización de pruebas UI y API para el sitio [Practice Software Testing](https://practicesoftwaretesting.com/), usando .NET, Selenium, SpecFlow y más.

## 📁 Estructura del Proyecto

```
QA.Interview/
├── Drivers/                    # Configuración del WebDriver
│   ├── chromedriver.exe
│   └── WebDriverFactory.cs
│
├── Features/                   # Archivos .feature con los escenarios en Gherkin
│   ├── CheckoutLogin.feature
│   ├── HandTools.feature
│   └── Rentals.feature
│
├── Hooks/                      # Hooks de SpecFlow (BeforeScenario, etc.)
│   └── TestHooks.cs
│
├── Pages/                      # Page Object Models (POM)
│   ├── CartPage.cs
│   ├── HandToolsPage.cs
│   ├── LoginPage.cs
│   ├── MainPage.cs
│   ├── PowerToolsPage.cs
│   └── RentalsPage.cs
│
├── StepDefinitions/            # Definiciones de pasos en SpecFlow
│   ├── CheckoutSteps.cs
│   ├── CommonSteps.cs
│   ├── HandToolSteps.cs
│   └── RentalsStep.cs
│
├── .gitignore                  # Archivos y carpetas ignoradas por Git
├── QA.Interview.csproj         # Archivo del proyecto .NET
├── app.config                  # Configuración de la ejecución (si aplica)
└── README.md                   # Documentación del proyecto
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

