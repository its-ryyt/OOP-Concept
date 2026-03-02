using System;
using System.Collections.Generic;

namespace OOPDemo
{
    // ================================
    // ABSTRACTION + ENCAPSULATION
    // ================================

    // Abstract base class (Abstraction)
    public abstract class Employee
    {
        // Encapsulation: private fields
        private string _name;
        private decimal _baseSalary;

        // Public property with validation
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

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

        // Constructor
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        // Abstract method (Abstraction)
        public abstract decimal CalculateSalary();

        // Virtual method (Polymorphism)
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Base Salary: {BaseSalary:C}");
        }
    }

    // ================================
    // INHERITANCE
    // ================================

    public class FullTimeEmployee : Employee
    {
        public decimal Bonus { get; set; }

        public FullTimeEmployee(string name, decimal baseSalary, decimal bonus)
            : base(name, baseSalary)
        {
            Bonus = bonus;
        }

        // Polymorphism (Method Override)
        public override decimal CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus:C}");
            Console.WriteLine($"Total Salary: {CalculateSalary():C}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked)
            : base(name, 0)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        // Polymorphism (Method Override)
        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Hours Worked: {HoursWorked}");
            Console.WriteLine($"Hourly Rate: {HourlyRate:C}");
            Console.WriteLine($"Total Salary: {CalculateSalary():C}");
        }
    }

    // ================================
    // MAIN PROGRAM
    // ================================
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee("Alice", 50000, 10000),
                new PartTimeEmployee("Bob", 500, 40)
            };

            foreach (var emp in employees)
            {
                Console.WriteLine("================================");
                emp.DisplayInfo();  // Polymorphism in action
            }

            Console.ReadLine();
        }
    }
}