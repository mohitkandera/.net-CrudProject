# .NET CRUD Project Using MVC

## 📖 Overview

This project is a CRUD (Create, Read, Update, Delete) application developed using **ASP.NET MVC**, **C#**, and **SQL Server**. It demonstrates how to perform database operations through the MVC (Model-View-Controller) architecture while following best practices for web application development.

---

## 🚀 Features

* Add New Records
* View All Records
* Update Existing Records
* Delete Records
* Search Records
* Form Validation
* Responsive User Interface
* Database Connectivity with Entity Framework
* MVC Architecture Implementation

---

## 🛠️ Technologies Used

* ASP.NET MVC
* C#
* .NET Framework / ASP.NET Core MVC
* Entity Framework
* SQL Server
* HTML5
* CSS3
* Bootstrap
* Razor View Engine

---

## 📂 Project Structure

```text
.NET-CrudProjectUsingMVC
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   └── Employee.cs
│
├── Views
│   └── Employee
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Details.cshtml
│       └── Delete.cshtml
│
├── Data
│   └── ApplicationDbContext.cs
│
├── wwwroot
│
├── appsettings.json
│
└── Program.cs
```

---

## 📊 CRUD Operations

### Create

* Add new employee records.
* Validate user input before saving.

### Read

* Display all employee records.
* View employee details.

### Update

* Edit employee information.
* Save updated data to the database.

### Delete

* Remove employee records from the database.

---

## 🗄️ Database Design

### Employee Table

| Column Name | Data Type |
| ----------- | --------- |
| EmployeeId  | int (PK)  |
| Name        | varchar   |
| Email       | varchar   |
| Department  | varchar   |
| Salary      | decimal   |
| CreatedDate | datetime  |

---

## ⚙️ Installation & Setup

### Clone Repository

```bash
git clone https://github.com/your-username/.NET-CrudProjectUsingMVC.git
```

### Navigate to Project Folder

```bash
cd .NET-CrudProjectUsingMVC
```

### Restore Packages

```bash
dotnet restore
```

### Update Database Connection

Modify the connection string in:

```json
appsettings.json
```

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

### Apply Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

Application URL:

```text
https://localhost:5001
```

---

## 📸 Screens Included

* Employee List Page
* Add Employee Page
* Edit Employee Page
* Employee Details Page
* Delete Confirmation Page

---

## 🔍 MVC Architecture

### Model

Represents application data and business logic.

Example:

```csharp
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}
```

### View

Responsible for displaying data to users using Razor Views.

### Controller

Handles requests and communicates between Model and View.

---

## 🎯 Learning Outcomes

* Understanding MVC Architecture
* Database Connectivity with SQL Server
* Entity Framework CRUD Operations
* Razor View Development
* Form Validation
* Routing and Controllers
* Model Binding

---

## 🔮 Future Enhancements

* Authentication & Authorization
* Role-Based Access Control
* Pagination
* Search & Filtering
* REST API Integration
* Export Data to Excel/PDF
* Dashboard Analytics

---

## 👨‍💻 Author

Developed using ASP.NET MVC, C#, Entity Framework, and SQL Server to demonstrate complete CRUD functionality following MVC architecture.
