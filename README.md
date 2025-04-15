
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

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- [SpecFlow](https://specflow.org/)
- [Selenium WebDriver](https://www.selenium.dev/)
- [ChromeDriver](https://chromedriver.chromium.org/)
- [Gherkin](https://cucumber.io/docs/gherkin/)
- [JetBrains Rider](https://www.jetbrains.com/rider/) (IDE)

## Ejecución de pruebas

1. **Restaurar dependencias y compilar el proyecto**:

   ```bash
   dotnet build
   ```

2. **Ejecutar los tests**:

   ```bash
   dotnet test
   ```

   Esto ejecutará todos los escenarios definidos en los `.feature`.

## Escenarios Automatizados

### Login inválido desde Checkout

Archivo: `CheckoutLogin.feature`

```gherkin
Scenario: Try to login with invalid email during checkout
   Given I am on the homepage
   When I navigate to the "Power Tools" section from the "Categories" menu
   And I select the first product
   And I add the product to the cart
   And I go to the cart and proceed to checkout
   And I enter an invalid email and any password
   And I click the login button
   Then I should see an error message for invalid credentials
```

### Filtro en Hand Tools *(por implementar/implementado)*

...

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

## 👤 Autor

Daniel – QA Automation Engineer en formación continua 
daniggcia@hotmail.com

