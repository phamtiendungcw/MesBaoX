# MesBaoX: Maximizing Enterprise Sales & Business Automation Online eXperience

[![Build Status](https://github.com/phamtiendungcw/MesBaoX/actions/workflows/main.yml/badge.svg)](https://github.com/phamtiendungcw/MesBaoX/actions/workflows/main.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=phamtiendungcw_MesBaoX&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=phamtiendungcw_MesBaoX)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](CONTRIBUTING.md)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE)

**MesBaoX** is an advanced e-commerce platform that provides powerful sales and business analytics solutions, optimized by the power of media integration. The project is built on **Clean Architecture** combined with the **CQRS** pattern, using **.NET Core 6** for the backend, **Angular 16** for the frontend, and **SQL Server/Oracle** for the database.

---

## 🌟 **Key Features**
- 🖥️ **Modern UI/UX**: Intuitive and responsive design powered by Angular.
- ⚙️ **Scalable Backend**: ASP.NET Core for high-performance and reliability.
- 🗄️ **Database Flexibility**: Supports SQL Server and Oracle Database.
- 📦 **Comprehensive Management**: Inventory, orders, customers, and payments in one place.
- 💳 **Secure Payment Gateway**: Integration with industry-standard payment systems.
- 📈 **Advanced Reporting**: Generate real-time insights for business decision-making.

---

## 🚀 **Getting Started**

### 1️⃣ **Clone the Repository**
```bash
git clone <https://github.com/phamtiendungcw/MesBaoX>
cd MesBaoX
```

### 2️⃣ **Set Up Backend**
- Open the MesBaoX.sln solution in **Visual Studio**.
- Restore NuGet packages:
  ```bash
  dotnet restore
  ```
- Configure database connection strings in `appsettings.json`.
- Open the Package Manager Console and run the following command to update the database:
  ```bash
  dotnet ef database update
  ```
- Set MBX.Server as the startup project. Then, press F5 or click the Start button (with the green play icon) to run the project.

### 3️⃣ **Set Up Frontend**
- Navigate to the Angular frontend folder:
  ```bash
  cd src/MBX.UI
  ```
- Install dependencies:
  ```bash
  npm install
  ```
- Start the Angular development server:
  ```bash
  ng serve
  ```

---

## 📂 **Project Structure**
```plaintext
MesBaoX/
├── src/
│   ├── MBX.Application/     # Application logic
│   ├── MBX.Domain/          # Core domain models
│   ├── MBX.Infrastructure/  # Infrastructure services
│   ├── MBX.Persistence/     # Database migrations and access
│   ├── MBX.Server/          # ASP.NET Core Web API
│   ├── MBX.UI/              # Angular frontend application
├── docs/                    # Project documentation
├── tests/                   # Project testing
├── LICENSE                  # License file
├── README.md                # Project overview
├── CONTRIBUTING.md          # Contribute to the project
└── MesBaoX.sln              # Solution file
```

---

## 🎯 Objectives

MesBaoX aims to provide medium and large businesses with a comprehensive tool to:

*   ✅ Efficiently manage products and orders.
*   📊 Perform in-depth analysis of sales data and customer behavior.
*   📈 Optimize business strategies based on real-time data.
*   🚀 Enhance operational efficiency through robust media integrations.

---

## 🏗️ Architecture

The project applies **Clean Architecture** to ensure flexibility, maintainability, and scalability. The project structure is divided into independent layers:

*   **Domain:** :classical_building: Contains core business entities (e.g., Product, Order, Customer), value objects (e.g., Address, Money), domain services (e.g., OrderCalculationService), and domain events (e.g., OrderCreatedEvent). It's independent of any specific frameworks or technologies.
*   **Application:** :gear: Contains use cases, implementing the **CQRS** pattern to separate read (Queries) and write (Commands) operations.
*   **Infrastructure:** :hammer_and_wrench: Contains specific implementations for database, caching, logging, external services, etc.
*   **Presentation:** :globe_with_meridians: Contains the Web API controllers (backend) and Angular components (frontend), responsible for interacting with the user and the Application layer.

**CQRS (Command Query Responsibility Segregation):** :left_right_arrow:

CQRS is used to segregate responsibilities between read and write operations, optimizing the performance and scalability of the system.

---

## 🛠️ **Tech Stack**

*   **Backend:** .NET Core 6, ASP.NET Core, Entity Framework Core
*   **Frontend:** Angular 16, TypeScript, RxJS, HTML5, CSS3
*   **Database:** SQL Server / Oracle
*   **API:** RESTful API
*   **Authentication/Authorization:** JWT (JSON Web Tokens)
*   **Caching:** Redis / Memcached (optional)
*   **Logging:** Serilog
*   **Testing:** xUnit / NUnit / MSTest (backend), Jasmine / Karma (frontend)
*   **CI/CD:** GitHub Actions

---

## 📜 **License**
This project is licensed under the [Apache 2.0 License](LICENSE).

---

## 🤝 **Contributing**
We welcome contributions!  
Feel free to submit pull requests, report issues, or suggest new features. Please follow our [contribution guidelines](CONTRIBUTING.md).

---

## 📧 **Contact**
For inquiries, please contact the development team at **[mesbaoxdev@gmail.com](mailto:mesbaoxdev@gmail.com)**.
