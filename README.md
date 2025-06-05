**Restructuring README**

El usuario desea actualizar el README agregando más carpetas sin crear listas largas. Quiere abordar temas como Blazor, inyección de dependencias, middlewares, y más

Pensado durante unos segundos

# .NET Learning Repository

A curated collection of hands-on C# and .NET exercises, aligned with Microsoft Learn (and earlier ZTM) courses. Each topic lives in its own folder with console applications and code samples to practice and reinforce key concepts.

---

## 📂 Project Structure

Below are the main topic folders. Several additional folders cover more advanced .NET areas (Blazor, Dependency Injection, Middleware, APIs, publishing, testing, etc.)—feel free to browse for details.

* **Basics/**
  Conditionals, loops, operators, strings, console I/O, and related fundamentals.

* **Intermediate/**
  Enums, exception handling, structs, switch expressions, method arguments, and more.

* **Advanced/**
  Named/optional arguments, `params` keyword, extension methods, generics, nullable types, record types, `async/await`, custom exceptions.

* **Arrays and Collections/**
  Array tutorials, `List<T>`, `Dictionary<TKey, TValue>`, queues, stacks, and final projects like the console-based Racing Calendar.

* **LINQ/**
  Filtering, ordering, selecting, grouping, and query-syntax examples.

* **OOP/**
  Classes, inheritance, interfaces, polymorphism, method overloading, namespaces, and small project examples.

* **Tests/**
  Unit tests for the `ProjectAccountingSystem` and other exercises, using MSTest.

> **Other folders you’ll find**
>
> * **Azure/AlpineSkiHouse/** – Azure deployment examples
> * **DotNetAPI/** – Building and consuming Web APIs
> * **DotNetBlazor/BlazorApp/** – Blazor Server/WebAssembly projects
> * **DotNetDebugging/** – Debugging techniques and examples
> * **DotNetDependencies/** – Using packages like Humanizer and more
> * **DotNetDependencyInjection/** – Exploring built-in DI patterns
> * **DotNetFiles/** – Working with files and directories
> * **DotNetFirstApp/** – First .NET console application tutorials
> * **DotNetMiddleware/** – Custom middleware in ASP.NET Core
> * **DotNetPublish/** – Publishing and deploying ASP.NET Core to Azure
> * **DotNetRazorPages/ContosoPizza/** – Razor Pages CRUD examples
> * **DotNetTests/** – Additional test projects beyond AccountingSystem

Each folder contains one or more console apps (or web apps) and code samples. To explore:

```bash
cd <folder>
dotnet run
```

---

## 🚀 Getting Started

1. **Clone the repository**

   ```bash
   git clone https://github.com/kdeavila/learning-dotnet.git
   cd learning-dotnet
   ```

2. **Open the solution** (`.sln`) in Visual Studio or VS Code.

3. **Run a sample**

   ```bash
   cd <TopicFolder>
   dotnet run
   ```

4. **Run all unit tests**

   ```bash
   dotnet test Tests/AccountingSystem.Tests
   ```

---

## 👤 Author

**Keyner de Ávila Gutiérrez**
Barranquilla, Colombia
[LinkedIn](https://www.linkedin.com/in/kdeavila9/) · [GitHub](https://github.com/kdeavila)

Feel free to explore, test, and provide feedback!
