# Scheduling Application
![C#](https://img.shields.io/badge/C%23-%23239120?style=flat&logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-512BD4?style=flat&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=flat&logo=windows&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/GitHub%20Actions-2088FF?style=flat&logo=githubactions&logoColor=white)

## A desktop scheduling application built using C# and .NET that allows users to manage customer information, appointments, and reports.

---

## Purpose of This Project

This project was developed to practice and demonstrate:

- Object-Oriented Programming in C#
- Windows Forms application design
- Data validation and input handling
- Database connectivity
- Application architecture and code organization

---

## Tech Stack

- C#
- .NET Framework
- Windows Forms
- SQL Database
- Object-Oriented Programming

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
```
ScheduleApp — Solution Structure

Solution/
│
├── ScheduleApp.sln              # Solution file
├── ScheduleApp.csproj           # Project configuration
├── Program.cs                   # Application entry point
│
├── Database/                    # DB connection & data access logic
├── Models/                      # Data models & entities
├── Properties/                  # Application configuration files
├── Utilities/                   # Helper methods & reusable logic
├── Validator/                   # Data validation for create / update
│
├── Forms/                       # WinForms UI screens
│   ├── loginForm.cs             # User authentication
│   ├── calendar.cs              # Main scheduling interface
│   ├── createAppt.cs            # Create new appointments
│   ├── updateAppt.cs            # Update existing appointments
│   ├── CustomerInformationForm.cs  # Manage customer records
│   ├── UpdateCustomerForm.cs    # Update customer details
│   └── ReportForm.cs            # Report selection interface
│
└── Reports/                     # Report screen classes
    ├── CountryReportMain.cs     # Appointments by country
    ├── MonthlyCurrentYearReportMain.cs  # Monthly statistics
    └── UserReportMain.cs        # User activity reporting
```

## Possible Future Improvements

- Upgrade UI to a modern framework (WPF or web-based UI)
- Add role-based authentication
- Improve reporting dashboard with charts
- Add automated testing (in progess)
- Containerize the database for easier deployment (in progress)
- Build a REST API backend for web access

---

## Skills Demonstrated

This project highlights experience with:

- C# application development
- Windows Forms UI design
- Database-driven applications
- Input validation and error handling
- Structured multi-layer application architecture
