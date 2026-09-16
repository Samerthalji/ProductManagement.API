# Product Management API

A decoupled ASP.NET Core Web API built for managing products and user authentication using **ASP.NET Core Identity** and **JWT (JSON Web Tokens)**.

---

## 🛠 Tech Stack

* **Framework:** ASP.NET Core Web API
* **ORM:** Entity Framework Core
* **Database:** SQL Server
* **Authentication:** ASP.NET Core Identity & JWT Bearer Token

---

## 🚀 Features

* **User Authentication:** Registration, Login, and Role-based management.
* **Security:** JWT authentication with token validation (Issuer, Audience, Lifetime, Key).
* **Product Management:** Full CRUD operations for products.
* **Architecture:** Decoupled architecture using `UserManager` and `RoleManager` (no direct SQL/Identity coupling).

---

## ⚙️ Getting Started

### 1. Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download)
* SQL Server

### 2. Configuration
Update `appsettings.json` with your database connection string and JWT settings:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ShopDb;Integrated Security=true;TrustServerCertificate=true;"
  },
  "Jwt": {
    "Issuer": "YOUR_ISSUER",
    "Audience": "YOUR_AUDIENCE",
    "Lifetime": 30,
    "Key": "YOUR_SECRET_KEY"
  }
}
