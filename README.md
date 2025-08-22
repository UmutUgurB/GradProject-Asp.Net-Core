BeFit - ASP.NET Core MVC Application

This project is an ASP.NET Core MVC application developed using an N-Tier architecture with Entity Framework Core and MS SQL Server. The main goal is to provide a clean separation of concerns and maintain a scalable, testable structure.

Table of Contents

Architecture Overview

Tech Stack

Solution Structure

Getting Started

Configuration

Database & Migrations

Running the Application

Contributing

License

Architecture Overview

The application follows a layered (N-Tier) architecture:

BeFit (Presentation - MVC)
        ↓
BusinessLayer (Business Logic, Services, Managers)
        ↓
BeFitDTO (Data Transfer Objects)
EntityLayer (Entities, Domain Models)
        ↓
DataAccessLayer (Repositories, EF Core DbContext)


BeFit: MVC project (Controllers, Views, Startup/Program.cs).

BusinessLayer: Contains service logic and managers.

BeFitDTO: Holds DTOs used for transferring data between layers.

EntityLayer: Defines domain entities and models.

DataAccessLayer: Implements repository pattern with Entity Framework Core.

Tech Stack

ASP.NET Core MVC (.NET 6 / .NET 7 / .NET 8 depending on setup)

Entity Framework Core

MS SQL Server

N-Tier Architecture

Repository Pattern

Solution Structure
BeFitLastVersion.sln
│
├── BeFit/              → MVC presentation layer
├── BusinessLayer/      → Business rules and service managers
├── BeFitDTO/           → DTOs for data transfer
├── EntityLayer/        → Entities and domain models
├── DataAccessLayer/    → EF Core DbContext and repository implementations
└── .vs/                → Visual Studio settings

Getting Started
Prerequisites

.NET SDK

MS SQL Server
 or Docker

Visual Studio 2022
 or VS Code

Clone the Repository
git clone https://github.com/your-username/GradProject-Asp.Net-Core.git
cd BeFitLastVersion

Configuration

Update your connection string in appsettings.json inside the BeFit project:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BeFitDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;"
  }
}


For localdb (Windows):

"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BeFitDb;Trusted_Connection=True;"

Database & Migrations

Run the following commands to manage the database:

# Add a migration
dotnet ef migrations add InitialCreate --project DataAccessLayer --startup-project BeFit

# Apply migrations
dotnet ef database update --project DataAccessLayer --startup-project BeFit

Running the Application
dotnet run --project BeFit


Open in browser: http://localhost:5000

Contributing

Fork the repository

Create a feature branch (git checkout -b feature/YourFeature)

Commit your changes (git commit -m "Add new feature")

Push to the branch (git push origin feature/YourFeature)

Create a Pull Request
