# Inventory Management System (ASP.NET Core MVC)

A working CRUD app for managing products in stock — built with ASP.NET Core MVC, EF Core (InMemory database), .NET 10.

## How to open and run

1. Unzip this folder anywhere on your computer.
2. Open **Visual Studio** → **File** → **Open** → **Project/Solution** → select `InventoryMVC.csproj` (there's no `.sln` file — opening the `.csproj` directly works fine and Visual Studio will create one).
3. Wait for Visual Studio to restore NuGet packages (bottom status bar shows progress — needs internet the first time to download the EF Core packages).
4. Press **F5** (or the green Run button).
5. Your browser opens straight to the product list at `/Products`.

## What it does

- Lists all products
- Add a new product (name, SKU, quantity, price)
- Edit an existing product
- View product details
- Delete a product

Data is stored **in memory** — it resets every time you stop and restart the app. That's intentional for today's demo; swapping to a real SQL Server database later is a small, well-documented change (see the main guide).

## Project structure

```
InventoryMVC/
├── Controllers/
│   ├── ProductsController.cs   ← CRUD logic
│   └── HomeController.cs       ← redirects to Products
├── Models/
│   ├── Product.cs              ← the data shape
│   └── InventoryContext.cs     ← EF Core database context
├── Views/
│   ├── Products/               ← Index, Create, Edit, Details, Delete pages
│   └── Shared/_Layout.cshtml   ← shared page layout/navbar
├── Program.cs                  ← app startup, wires EF Core + MVC
└── InventoryMVC.csproj         ← project file + package references
```

## Troubleshooting

- **NuGet restore fails / red squiggles on `using Microsoft.EntityFrameworkCore`**: right-click the project → Manage NuGet Packages → make sure `Microsoft.EntityFrameworkCore.InMemory` and `Microsoft.EntityFrameworkCore.Design` are installed (they're already referenced in the `.csproj`, but the actual files need to download once).
- **Target framework error**: if you don't have the .NET 10 SDK, right-click the project → Edit Project File → change `<TargetFramework>net10.0</TargetFramework>` to whatever SDK you have (e.g. `net8.0`), then Save.
