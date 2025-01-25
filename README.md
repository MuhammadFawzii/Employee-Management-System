# Employee Management Application

## Overview

This repository contains the implementation of an Employee Management Application as part of a programming assignment. The application is designed to manage employees, departments, projects, and budgets. It provides functionalities to add, edit, delete, and search for employees, calculate payroll, manage departments, and handle project budgets.

The application is built using **Object-Oriented Programming (OOP) concepts**, ensuring a modular, reusable, and maintainable codebase. Key OOP principles such as **encapsulation**, **inheritance**, **polymorphism**, and **abstraction** are applied throughout the design and implementation.

---

## Features

- **Employee Management**: Add, edit, delete, and search for employees.
- **Payroll Calculation**: Calculate payroll for different types of employees (Hourly, Salaried, Commission, Executive).
- **Department Management**: Add and manage departments using a dedicated list in the `Department` class.
- **Project Management**: Add projects, manage budgets, and assign managers using a dedicated list in the `Project` class.
- **Staff Management**: Manage staff members using a dedicated list in the `Staff` class.
- **Budget Management**: Increase and manage budgets for projects.

---

## Download the Project

You can download the project files by clicking the link below:

- **[Download Employee Management PDF](/Employee_Management.pdf)**

```plaintext
- **Department**
  - departID: int
  - departName: string
  - departmentList: List<Department>
  + print(): void
  + addDepartment(): void
  + printAllDepartments(): void

- **StaffMember**
  - employeeID: int
  - name: string
  - phone: string
  - email: string
  + Print(): string
  + Pay(): double

- **Staff**
  - staffList: List<StaffMember>
  + calcPayroll(): void
  + addMember(): void
  + delMember(): void
  + ShowAll(): void
  + searchMember(): void

- **Volunteer**
  - amount
  + Print(): string
  + Pay(): double

- **Employee**
  - socialSecurityNumber: string
  + Print(): string
  + Pay(): double

- **Project**
  - projectID: int
  - location: string
  - manager: Employee
  - currentCost: double
  - budgetList: List<Budget>
  - projectList: List<Project>
  + addBudget(value): void
  + getTotalBudget(value): void
  + print(): void
  + addProject(): void
  + printAllProjects(): void

- **Hourly Employee**
  - hoursWorked: double
  - rate: double
  + addHours(moreHours: int): void
  + Pay(): double
  + Print(): string

- **Salaried Employee**
  + salary: double
  + Pay(): double
  + Print(): string

- **Commission Employee**
  + target: double
  + Pay(): double
  + Print(): string

- **Executive Employee**
  - bonus: double
  + addBonus(moreBonus: double): void
  + Pay(): double
  + Print(): string

- **Budget**
  - id: int
  - value: double
  + increaseBudget(amount: double): void
```
