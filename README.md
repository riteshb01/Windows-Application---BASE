# Windows-Application---BASE
A C# WinForms application for managing tech gadget collections, demonstrating object-oriented programming with Class inheritance, polymorphism and method overriding.


🎯 Features
Add Gadgets - Input name, brand, price, category, purchase date, and warranty information
View Collection - Display all gadgets in a DataGridView with sortable columns
Warranty Tracking - Track warranty periods for each gadget
🏗️ Architecture
This project demonstrates object-oriented programming principles:

Inheritance - TechGadget extends CollectionItem base class
Polymorphism - Overridden GetSummary() method
Encapsulation - Properties with getters/setters

📁 Project Structure
CollectionItem.cs - Base class with core properties
TechGadget.cs - Derived class with warranty feature
MainForm.cs - Application entry point
AddItemForm.cs - Form for adding new gadgets
ViewItemsForm.cs - Form for viewing collection

🛠️ Technologies
C# / .NET
Windows Forms
Visual Studio
