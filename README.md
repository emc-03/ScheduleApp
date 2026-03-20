# Scheduling Application

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=flat&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=flat&logo=windows&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-4479A1?style=flat&logo=mysql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?style=flat&logo=githubactions&logoColor=white)

A desktop scheduling application built using C# and .NET that allows users to manage customer information, appointments, and reports.

---

## Purpose of This Project

This project was developed to practice and demonstrate:

- Object-Oriented Programming in C#
- Windows Forms application design
- Data validation and input handling
- Database connectivity
- Application architecture and code organization
- Modern SDK-style .NET project structure
- Shared core library design across multiple projects

---

## Tech Stack

- C# / .NET 10
- Windows Forms
- SQL Database
- Object-Oriented Programming
- xUnit (Phase 2 — in progress)
- ASP.NET Core Web API (Phase 4 — planned)

---

## Key Features

- User login system
- Customer management (create, update, validate data)
- Appointment scheduling and modification
- Calendar view for appointments
- Input validation and error handling
- Report generation, including:
  - User activity reports
  - Monthly appointment reports
  - Country reports

---

## Example Application Workflow

1. User logs into the application
2. Customer records can be created or updated
3. Appointments are scheduled or modified
4. Calendar displays upcoming appointments
5. Reports provide insights into scheduling activity

---

## Solution Structure

```
Solution/
├── ScheduleApp.sln                       # Solution file
├── README.md
├── .gitignore
│
├── ScheduleApp/                          # WinForms desktop application
│   ├── ScheduleApp.csproj                # net10.0-windows, SDK-style
│   ├── Program.cs                        # Application entry point
│   ├── App.config
│   │
│   ├── models/                           # Legacy model references (see Core)
│   │
│   ├── Database/                         # DB connection & data access logic
│   │   ├── DB_Connection.cs
│   │   ├── AppointmentData.cs
│   │   ├── CustomerData.cs
│   │   ├── UserData.cs
│   │   ├── CityData.cs
│   │   ├── AddressData.cs
│   │   └── CountryData.cs
│   │
│   ├── Properties/                       # Application configuration files
│   ├── Utilities/                        # Helper methods & reusable logic
│   ├── Validator/                        # Data validation for create / update
│   │
│   ├── calendar.cs                       # Calendar view
│   ├── loginForm.cs                      # User authentication
│   ├── createAppt.cs                     # Create new appointments
│   ├── updateAppt.cs                     # Update existing appointments
│   ├── CustomerInformationForm.cs        # Manage customer records
│   ├── UpdateCustomerForm.cs             # Update customer details
│   ├── ReportForm.cs                     # Report selection interface
│   ├── CountryReportMain.cs              # Appointments by country
│   ├── MonthlyCurrentYearReportMain.cs   # Monthly statistics
│   └── UserReportMain.cs                 # User activity reporting
│
├── ScheduleApp.Core/                     # Shared models & interfaces (net10.0)
│   ├── ScheduleApp.Core.csproj
│   ├── Models/
│   │   ├── Appointment.cs
│   │   ├── Customer.cs
│   │   ├── Address.cs
│   │   ├── City.cs
│   │   ├── Country.cs
│   │   ├── User.cs
│   │   └── ValidationResult.cs
│   └── Interfaces/
│       ├── IAppointmentRepository.cs
│       └── ICustomerRepository.cs
│
├── ScheduleApp.Api/                      # REST API — Phase 4 (planned)
│   └── .gitkeep
│
└── ScheduleApp.Tests/                    # xUnit test project — Phase 2 (planned)
    └── .gitkeep
```

---

## Possible Future Improvements

- Upgrade UI to a modern framework (WPF or web-based UI)
- Add role-based authentication
- Improve the reporting dashboard with charts
- Add automated testing (in progress)
- Containerize the database for easier deployment (in progress)
- Build a REST API backend for web access
- Nullable reference type annotations — 79 CS8618/CS8602 warnings identified during net10 migration, tracked for future cleanup pass

---

## DevOps Lab

Experiments and automation work in progress for this project:

- CI/CD pipeline — automated build & test on every push *(Phase 3 — planned)*
- REST API layer — companion service exposing appointment data via HTTP *(Phase 4 — planned)*
- xUnit test suite — unit tests for validation and business logic *(Phase 2 — in progress)*

---

## Skills Demonstrated

This project highlights experience with:

- C# application development
- Windows Forms UI design
- Database-driven applications
- Input validation and error handling
- Structured multi-layer application architecture
- Modern SDK-style .NET project migration
- Multi-project solution design with shared Core library

