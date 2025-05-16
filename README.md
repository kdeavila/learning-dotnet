# .NET Learning Repository

A curated collection of my hands‑on C# and .NET exercises, aligned with Microsoft Learn and ZTM courses. Each topic lives in its own folder with console applications and code samples to practice and reinforce key concepts.

---

## 📂 Project Structure

* **Basics/**

  * Conditionals, loops, operators, strings, I/O, etc.
* **Intermediate/**

  * Enums, exception handling, structs, switch expressions, method arguments, etc.
* **Advanced/**

  * Named/optional arguments, `params` keyword, extension methods, generics, nullable types, record types, `async/await`, custom exceptions
* **Arrays and Collections/**

  * Arrays, `List<T>`, `Dictionary<TKey,TValue>`, queues, stacks, and more
* **LINQ/**

  * Filtering, ordering, selecting, grouping, and query syntax
* **OOP/**

  * Classes, inheritance, interfaces, polymorphism, method overloading, namespaces, project examples
* **Tests/**

  * Unit tests for the `ProjectAccountingSystem` using MSTest — includes `DepositTests.cs`, `CheckingAccountTest.cs`, `PremiumAccountTests.cs`, `MSTestSettings.cs`, `Test1.cs`

Each folder contains one or more console apps or code samples. To explore:

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
2. **Open the solution** (`.sln`) in Visual Studio or VS Code.
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
[LinkedIn](https://www.linkedin.com/in/kdeavila9) · [GitHub](https://github.com/kdeavila)
Feel free to explore, test, and provide feedback!
