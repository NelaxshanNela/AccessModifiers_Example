Order Management System

This is a simple Order Management System built with ASP.NET Core and Entity Framework. It allows users to manage orders, view order details, and perform CRUD operations.

Prerequisites

Before starting, make sure you have the following installed:

.NET SDK

Visual Studio or Visual Studio Code

SQL Server (if using a database)

Git

Steps to Create the Project from Scratch

Step 1: Create a New ASP.NET Core Web API Project

mkdir OrderManagementSystem
cd OrderManagementSystem
dotnet new webapi -n OrderManagementSystem
cd OrderManagementSystem

Step 2: Add Required Packages

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Swashbuckle.AspNetCore

Step 3: Create the Models

Create Models/Order.cs

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}

Step 4: Create the Database Context

Create Data/ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Order> Orders { get; set; }
}

Step 5: Configure Database in appsettings.json

"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=OrderDB;Trusted_Connection=True;"
}

Step 6: Register Database Context in Program.cs

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

Step 7: Create a Controller

Create Controllers/OrdersController.cs

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public OrdersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(_context.Orders.ToList());
    }
}

Step 8: Apply Migrations and Update Database

dotnet ef migrations add InitialCreate
dotnet ef database update

Step 9: Run the Application

dotnet run

Open Swagger UI at:

http://localhost:5000/swagger

Step 10: Push the Project to GitHub

Initialize Git Repository

git init
git add .
git commit -m "Initial commit"

Create a Repository on GitHub

Go to GitHub and create a new repository.

Push the Project to GitHub

git remote add origin https://github.com/YOUR_USERNAME/OrderManagementSystem.git
git branch -M main
git push -u origin main

API Endpoints

HTTP Method

Route

Description

GET

/api/orders

Get all orders

License

This project is open-source under the MIT License.

Author

Developed by Your Name.

Happy Coding! 🚀
