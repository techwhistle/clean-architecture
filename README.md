# BlogApi 📝

A simple **Blog API** built with **.NET 8**, following **Clean Architecture** principles.  
This project uses **Entity Framework Core** with **PostgreSQL** as the database provider.  

---

## 🚀 Features
- Clean Architecture with separated layers (`Domain`, `Application`, `Infrastructure`, `Web`)
- CRUD for Blog Posts
- Entity Framework Core with Migrations
- PostgreSQL integration
- Configurable via `appsettings.json`
- Ready for Docker deployment

---

## 🛠️ Tech Stack
- [.NET 8](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [PostgreSQL](https://www.postgresql.org/)
- [Docker](https://www.docker.com/) (optional for containerization)

---

## 📂 Project Structure
BlogApi/
├── BlogApi.Domain/ # Entities, Interfaces, Domain logic
├── BlogApi.Application/ # Application services, DTOs, CQRS, Validators
├── BlogApi.Infrastructure/ # EF Core, Repositories, Configurations
│ └── Persistence/Migrations/ # Database Migrations
├── BlogApi.Web/ # API Layer (Controllers, Endpoints, Startup)
└── README.md


---

## ⚙️ Setup & Run

### 1️⃣ Clone Repository
```bash
git clone https://github.com/techwhistle/clean-architecture
cd BlogApi
```

### 2️⃣ Set Up Database

Make sure PostgreSQL is installed and running.
Update the connection string in appsettings.json (inside BlogApi.Web):

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=blogdb;Username=postgres;Password=yourpassword"
}
```

3️⃣ Run Migrations

```bash
# From Visual Studio Package Manager Console
Update-Database

# OR from CLI
dotnet ef database update --project BlogApi.Infrastructure --startup-project BlogApi.Web

```

4️⃣ Run the Project
```bash
dotnet run --project BlogApi.Web
```

5️⃣ Test the API
API will be available at:
👉 https://localhost:5001/swagger



📖 Useful Commands
Add Migration
```bash
dotnet ef migrations add MigrationName --project BlogApi.Infrastructure --startup-project BlogApi.Web --output-dir Persistence/Migrations
```

Remove Last Migration
```bash
dotnet ef migrations remove --project BlogApi.Infrastructure --startup-project BlogApi.Web
```


🤝 Contribution
PRs are welcome!

1. Fork this repo
2. Create a new branch
3. Commit your changes
4. Push & open a Pull Request


**Copyright (c) 2025 Techwhistle**