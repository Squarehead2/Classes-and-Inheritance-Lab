# Modern Appliances Checkout System - C# .NET Framework

**📌 Overview**

This is a C# .NET Framework command-line application designed as an assignment to demonstrate object-oriented programming (OOP) concepts. The application allows users to checkout appliances, search for appliances by brand, display appliances by type, generate a random appliance list, and save progress before exiting.

**🛠 Technologies Used**

Language: C#

Framework: .NET 6.0

Concepts Demonstrated:

Classes & Objects

Inheritance & Polymorphism

Encapsulation & Abstraction

File I/O for data persistence

**🚀 Features**

🛒 Checkout Appliances – Allows users to check out available appliances by entering an item number.

🔍 Search by Brand – Find all appliances of a particular brand.

🏷 Display by Type – Show a list of appliances grouped by type (e.g., Refrigerators, Microwaves, Vacuums, Dishwashers).

🎲 Generate Random Appliance List – Display a randomly selected subset of appliances.

💾 Save & Exit – Ensures progress is saved before quitting the application.

**📂 Project Structure**

```
OOB_Assignment1/
│── Properties/
│── Resources/
│── bin/Debug/net6.0/
│── obj/
│── Applicance.cs          # Base class for all appliances
│── Dishwashers.cs         # Derived class for dishwashers
│── Microwaves.cs          # Derived class for microwaves
│── OOB_Assignment1.csproj # Project configuration file
│── ProblemDomain.cs       # Core logic handling appliance functions
│── Refrigerators.cs       # Derived class for refrigerators
│── Vacuums.cs            # Derived class for vacuums
│── OOB_Assignment1.sln    # Solution file
│── output.txt             # Output logs for testing
```

