# Employee Management API

This is a simple Employee Management API built using **ASP.NET Core** and **Entity Framework Core**.

## Features
- Add Employees (`POST /api/employees`)
- Retrieve Employees (`GET /api/employees`)
- Uses **SQL Server Database** with **EF Core**
- Swagger UI for API Testing

## How to Run
1. Clone the repository:

git clone https://github.com/Saritha-yelgam88/EmployeeManagementAPI.git

2. Open the project in **Visual Studio**.
3. Ensure SQL Server is running and update your `appsettings.json` connection string.
4. Run the project and open **Swagger UI** at `http://localhost:PORT/swagger` to test the API.

## Technologies Used
- **.NET Core 8**
- **Entity Framework Core**
- **SQL Server**
- **Swagger**
- **GitHub**

## 📂 Database Schema

The SQL script for creating the database tables is available in **[database.sql](https://github.com/Saritha-yelgam88/EmployeeManagementAPI/blob/main/database.sql)**.

To set up the database:
1. Download the `database.sql` file.
2. Open **SQL Server Management Studio (SSMS)**.
3. Execute the script to create the tables.

This script creates three tables:

Employees – Stores employee details like name, address, and hourly pay.
Supervisors – Stores supervisor details, including annual salary.
Managers – Stores manager details with an annual salary and max expense allowance.


