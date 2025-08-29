
## 🧪 SwagLabTestBDD Framework (.NET C#)

### Overview
SwagLabTestBDD is a comprehensive **Behavior-Driven Development (BDD)** test automation framework built using **C# .NET** and **NUnit**, designed to test both **UI** and **API** layers of the Swag Labs application. It integrates **RestSharp** for API testing, **Selenium WebDriver** for UI automation, **loggers** for execution tracking, and **ReportPortal** for advanced reporting.

---

### 🏗️ Project Structure

```
SwagLabTestBDD/
│
├── Features/               # Gherkin feature files
├── StepDefinitions/        # Step definitions for UI and API
├── Pages/                  # Page Object Model classes
├── Clients/                # RestSharp API clients
├── Models/                 # API request/response models
├── Utilities/              # Logging, config, helpers
├── Hooks/                  # Test setup and teardown
├── Reports/                # ReportPortal integration
├── Config/                 # Environment configs
├── SwagLabTestBDD.sln      # Solution file
└── README.md
```

---

### 🛠️ Technologies Used

- **C# .NET**
- **NUnit**
- **SpecFlow** (for BDD)
- **Selenium WebDriver**
- **RestSharp**
- **Log4Net / Serilog**
- **ReportPortal**
- **Newtonsoft.Json**
- **Extent Reports (optional)**

---

### 🚀 How to Run Tests

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/SwagLabTestBDD.git
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Run tests**
   ```bash
   dotnet test
   ```

---

### 📄 Feature Files

Feature files are written in **Gherkin syntax** and located in the `Features/` directory. They describe test scenarios for both UI and API flows.

---

### 📊 Reporting

- **ReportPortal** integration provides:
  - Real-time dashboards
  - Execution logs and screenshots
  - Historical test trends
  - CI/CD compatibility

---

### 🔐 Logging

- Configured using **Log4Net** or **Serilog**
- Logs are stored in the `Reports/Logs/` directory
- Supports different log levels (INFO, DEBUG, ERROR)

---

### 🧪 Sample API Test Step

```csharp
[Given(@"I send a GET request to the user endpoint")]
public void GivenISendAGetRequestToTheUserEndpoint()
{
    var response = _userClient.GetUserById(1);
    ScenarioContext.Current["ApiResponse"] = response;
}
```

---

### 👨‍💻 Author

**Sumanta Swain**  
Junior Software Test Automation Engineer  
