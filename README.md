# C969 Scheduling Application

A desktop scheduling application built using C# and .NET that allows users to manage customer information, appointments, and reports.

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
Working Tree : 
<svg width="860" height="940" viewBox="0 0 860 940" xmlns="http://www.w3.org/2000/svg" font-family="ui-monospace, 'Cascadia Code', 'Segoe UI Mono', monospace">

  <rect width="860" height="940" rx="12" fill="#0d1117"/>

  <!-- Title -->
  <text x="40" y="46" font-size="15" font-weight="600" fill="#e6edf3">ScheduleApp — Solution Structure</text>
  <line x1="40" y1="58" x2="820" y2="58" stroke="#30363d" stroke-width="1"/>

  <!-- ── ROOT ── -->
  <text x="40" y="92" font-size="13" fill="#8b949e">📁</text>
  <text x="60" y="92" font-size="13" font-weight="700" fill="#58a6ff">Solution/</text>
  <text x="280" y="92" font-size="12" fill="#484f58">── Solution root</text>

  <!-- trunk -->
  <line x1="48" y1="96" x2="48" y2="880" stroke="#30363d" stroke-width="1" stroke-dasharray="2 3"/>

  <!-- ── ScheduleApp.sln ── -->
  <line x1="48" y1="120" x2="72" y2="120" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="124" font-size="13" fill="#3fb950">📄</text>
  <text x="98" y="124" font-size="13" font-weight="600" fill="#e6edf3">ScheduleApp.sln</text>
  <text x="310" y="124" font-size="12" fill="#484f58">── Solution file</text>

  <!-- ── ScheduleApp.csproj ── -->
  <line x1="48" y1="152" x2="72" y2="152" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="156" font-size="13" fill="#3fb950">📄</text>
  <text x="98" y="156" font-size="13" font-weight="600" fill="#e6edf3">ScheduleApp.csproj</text>
  <text x="310" y="156" font-size="12" fill="#484f58">── Project configuration</text>

  <!-- ── Program.cs ── -->
  <line x1="48" y1="184" x2="72" y2="184" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="188" font-size="13" fill="#3fb950">📄</text>
  <text x="98" y="188" font-size="13" font-weight="600" fill="#e6edf3">Program.cs</text>
  <text x="310" y="188" font-size="12" fill="#484f58">── Application entry point</text>

  <!-- separator -->
  <line x1="48" y1="208" x2="820" y2="208" stroke="#21262d" stroke-width="1"/>

  <!-- ── Database/ ── -->
  <line x1="48" y1="232" x2="72" y2="232" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="236" font-size="13" fill="#e3b341">📂</text>
  <text x="98" y="236" font-size="13" font-weight="700" fill="#e3b341">Database/</text>
  <text x="310" y="236" font-size="12" fill="#484f58">── DB connection &amp; data access logic</text>

  <!-- ── Models/ ── -->
  <line x1="48" y1="264" x2="72" y2="264" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="268" font-size="13" fill="#e3b341">📂</text>
  <text x="98" y="268" font-size="13" font-weight="700" fill="#e3b341">Models/</text>
  <text x="310" y="268" font-size="12" fill="#484f58">── Application data models &amp; entities</text>

  <!-- ── Properties/ ── -->
  <line x1="48" y1="296" x2="72" y2="296" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="300" font-size="13" fill="#e3b341">📂</text>
  <text x="98" y="300" font-size="13" font-weight="700" fill="#e3b341">Properties/</text>
  <text x="310" y="300" font-size="12" fill="#484f58">── Application configuration files</text>

  <!-- ── Utilities/ ── -->
  <line x1="48" y1="328" x2="72" y2="328" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="332" font-size="13" fill="#e3b341">📂</text>
  <text x="98" y="332" font-size="13" font-weight="700" fill="#e3b341">Utilities/</text>
  <text x="310" y="332" font-size="12" fill="#484f58">── Helper methods &amp; reusable logic</text>

  <!-- ── Validator/ ── -->
  <line x1="48" y1="360" x2="72" y2="360" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="364" font-size="13" fill="#e3b341">📂</text>
  <text x="98" y="364" font-size="13" font-weight="700" fill="#e3b341">Validator/</text>
  <text x="310" y="364" font-size="12" fill="#484f58">── Data validation for create / update</text>

  <!-- separator -->
  <line x1="48" y1="384" x2="820" y2="384" stroke="#21262d" stroke-width="1"/>

  <!-- ── Forms/ ── -->
  <line x1="48" y1="408" x2="72" y2="408" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="412" font-size="13" fill="#58a6ff">📂</text>
  <text x="98" y="412" font-size="13" font-weight="700" fill="#58a6ff">Forms/</text>
  <text x="310" y="412" font-size="12" fill="#484f58">── WinForms UI screens</text>

  <!-- Forms trunk -->
  <line x1="118" y1="416" x2="118" y2="680" stroke="#30363d" stroke-width="1" stroke-dasharray="2 3"/>

  <!-- loginForm -->
  <line x1="118" y1="440" x2="142" y2="440" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="444" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="444" font-size="13" fill="#e6edf3">loginForm.cs</text>
  <text x="380" y="444" font-size="12" fill="#484f58">── User authentication</text>

  <!-- calendar -->
  <line x1="118" y1="468" x2="142" y2="468" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="472" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="472" font-size="13" fill="#e6edf3">calendar.cs</text>
  <text x="380" y="472" font-size="12" fill="#484f58">── Main scheduling interface</text>

  <!-- createAppt -->
  <line x1="118" y1="496" x2="142" y2="496" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="500" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="500" font-size="13" fill="#e6edf3">createAppt.cs</text>
  <text x="380" y="500" font-size="12" fill="#484f58">── Create new appointments</text>

  <!-- updateAppt -->
  <line x1="118" y1="524" x2="142" y2="524" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="528" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="528" font-size="13" fill="#e6edf3">updateAppt.cs</text>
  <text x="380" y="528" font-size="12" fill="#484f58">── Update existing appointments</text>

  <!-- CustomerInformationForm -->
  <line x1="118" y1="552" x2="142" y2="552" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="556" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="556" font-size="13" fill="#e6edf3">CustomerInformationForm.cs</text>
  <text x="460" y="556" font-size="12" fill="#484f58">── Manage customer records</text>

  <!-- UpdateCustomerForm -->
  <line x1="118" y1="580" x2="142" y2="580" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="584" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="584" font-size="13" fill="#e6edf3">UpdateCustomerForm.cs</text>
  <text x="460" y="584" font-size="12" fill="#484f58">── Update customer details</text>

  <!-- ReportForm -->
  <line x1="118" y1="608" x2="142" y2="608" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="612" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="612" font-size="13" fill="#e6edf3">ReportForm.cs</text>
  <text x="380" y="612" font-size="12" fill="#484f58">── Report selection interface</text>

  <!-- separator -->
  <line x1="48" y1="636" x2="820" y2="636" stroke="#21262d" stroke-width="1"/>

  <!-- ── Reports/ ── -->
  <line x1="48" y1="660" x2="72" y2="660" stroke="#30363d" stroke-width="1"/>
  <text x="78" y="664" font-size="13" fill="#f78166">📂</text>
  <text x="98" y="664" font-size="13" font-weight="700" fill="#f78166">Reports/</text>
  <text x="310" y="664" font-size="12" fill="#484f58">── Report screen classes</text>

  <!-- Reports trunk -->
  <line x1="118" y1="668" x2="118" y2="792" stroke="#30363d" stroke-width="1" stroke-dasharray="2 3"/>

  <!-- CountryReportMain -->
  <line x1="118" y1="692" x2="142" y2="692" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="696" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="696" font-size="13" fill="#e6edf3">CountryReportMain.cs</text>
  <text x="460" y="696" font-size="12" fill="#484f58">── Appointments by country</text>

  <!-- MonthlyCurrentYearReportMain -->
  <line x1="118" y1="720" x2="142" y2="720" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="724" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="724" font-size="13" fill="#e6edf3">MonthlyCurrentYearReportMain.cs</text>
  <text x="530" y="724" font-size="12" fill="#484f58">── Monthly statistics</text>

  <!-- UserReportMain -->
  <line x1="118" y1="748" x2="142" y2="748" stroke="#30363d" stroke-width="1"/>
  <text x="148" y="752" font-size="13" fill="#7ee787">📄</text>
  <text x="168" y="752" font-size="13" fill="#e6edf3">UserReportMain.cs</text>
  <text x="460" y="752" font-size="12" fill="#484f58">── User activity reporting</text>

  <!-- bottom rule -->
  <line x1="40" y1="790" x2="820" y2="790" stroke="#30363d" stroke-width="1"/>

  <!-- legend -->
  <rect x="40" y="808" width="10" height="10" rx="2" fill="#e3b341"/>
  <text x="56" y="818" font-size="11" fill="#8b949e">Folder</text>
  <rect x="120" y="808" width="10" height="10" rx="2" fill="#58a6ff"/>
  <text x="136" y="818" font-size="11" fill="#8b949e">Forms</text>
  <rect x="200" y="808" width="10" height="10" rx="2" fill="#f78166"/>
  <text x="216" y="818" font-size="11" fill="#8b949e">Reports</text>
  <rect x="290" y="808" width="10" height="10" rx="2" fill="#3fb950"/>
  <text x="306" y="818" font-size="11" fill="#8b949e">Config / root file</text>
  <rect x="420" y="808" width="10" height="10" rx="2" fill="#7ee787"/>
  <text x="436" y="818" font-size="11" fill="#8b949e">.cs source file</text>

</svg>

## Possible Future Improvements

- Upgrade UI to a modern framework (WPF or web-based UI)
- Add role-based authentication
- Improve reporting dashboard with charts
- Add automated testing
- Containerize the database for easier deployment
- Build a REST API backend for web access

---

## Skills Demonstrated

This project highlights experience with:

- C# application development
- Windows Forms UI design
- Database-driven applications
- Input validation and error handling
- Structured multi-layer application architecture
