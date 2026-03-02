# 📘 OOP Pillars Demo – C# Console Application

A simple and practical **C# Console Application** that demonstrates the **Four Pillars of Object-Oriented Programming (OOP)**:

- ✅ Encapsulation  
- ✅ Abstraction  
- ✅ Inheritance  
- ✅ Polymorphism  

This project uses a real-world inspired **Employee Management System** to explain how OOP works in practice.

---

# 🏗 Project Overview

This application simulates a company with different types of employees:

- Full-Time Employees
- Part-Time Employees

Each employee calculates salary differently while sharing a common structure.

This design demonstrates:
- Clean architecture principles
- Reusability
- Extensibility
- Proper separation of concerns

---

# 🧱 OOP Pillars Explained in This Project

## 1️⃣ Encapsulation

Encapsulation is implemented by:

- Using `private` fields
- Exposing controlled `public` properties
- Adding validation logic inside setters

Example:

```csharp
private decimal _baseSalary;

public decimal BaseSalary
{
    get { return _baseSalary; }
    set
    {
        if (value < 0)
            throw new ArgumentException("Salary cannot be negative.");
        _baseSalary = value;
    }
}
```

This prevents invalid object states.

---

## 2️⃣ Abstraction

Abstraction is achieved using an `abstract` base class:

```csharp
public abstract class Employee
{
    public abstract decimal CalculateSalary();
}
```

The base class defines **what must be done**, but not **how it is done**.

Each employee type provides its own implementation.

---

## 3️⃣ Inheritance

Concrete employee types inherit from the base `Employee` class:

```csharp
public class FullTimeEmployee : Employee
```

This allows:
- Code reuse
- Shared structure
- Extensibility

---

## 4️⃣ Polymorphism

Polymorphism is demonstrated using method overriding:

```csharp
public override decimal CalculateSalary()
```

And executed via:

```csharp
List<Employee> employees = new List<Employee>();
```

Even though the list is of type `Employee`, the correct overridden method is executed at runtime.

This is called **Runtime Polymorphism (Dynamic Dispatch)**.

---

# ▶️ How to Run the Project

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/your-repo-name.git
```

### 2️⃣ Navigate to the Project Folder

```bash
cd your-repo-name
```

### 3️⃣ Run the Application

```bash
dotnet run
```

Make sure you have:

- .NET SDK 6 or later installed

Check version:

```bash
dotnet --version
```

---

# 📂 Project Structure

```
OOPDemo/
│
├── Program.cs
├── Employee.cs
├── FullTimeEmployee.cs
├── PartTimeEmployee.cs
└── README.md
```

---

# 🖥 Sample Output

```
================================
Name: Alice
Base Salary: $50,000.00
Bonus: $10,000.00
Total Salary: $60,000.00

================================
Name: Bob
Base Salary: $0.00
Hours Worked: 40
Hourly Rate: $500.00
Total Salary: $20,000.00
```

---

# 🎯 Learning Objectives

By studying this project, you will understand:

- How abstraction forces implementation
- How inheritance reduces duplication
- How polymorphism enables flexible design
- How encapsulation protects data integrity
- How OOP is applied in real backend systems

---

# 🚀 Why This Matters

These OOP concepts are foundational for:

- ASP.NET Core Applications
- Clean Architecture
- SOLID Principles
- Dependency Injection
- Enterprise-level backend systems

This is the same structure used in professional .NET systems.

---

# 🛠 Built With

- C#
- .NET Console Application
- Object-Oriented Programming Principles

---

# 📌 Future Improvements

Possible enhancements:

- Add Interface-based implementation
- Implement Dependency Injection
- Add a Manager class
- Add file/database persistence
- Convert into ASP.NET Core Web API

---

# 🤝 Contributing

Feel free to fork the repository and improve it.

Pull requests are welcome!

---

# 📜 License

This project is open-source and available under the MIT License.
