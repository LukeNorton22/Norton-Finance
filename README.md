# Norton-Finance API

## This API is still under development

## Overview

Norton-Finance API is a backend API developed to serve as the core for a personal finance application. This API is designed to provide a simple and straightforward way to track personal spending and income, leveraging the power of the Plaid API for real-time financial data integration. Built with .NET 8 and Entity Framework Core, this API is optimized for clarity, simplicity, and ease of use.

## Key Features

- Plaid API Integration:
  - Connects to user bank accounts to track spending and income.
  - Provides real-time transaction data and categorizes expenses.

- Personal Finance Management:
  - Allows users to monitor their income and expenses in a consolidated view.
  - Simple tools for budgeting and financial planning.

- Data Storage:
  - Uses PostgreSQL to store user financial data, transaction history, and account information securely.

- User Authentication and Security:
  - Implements secure user authentication and authorization.
  - Ensures that all financial data is protected and only accessible to authorized users.

## Technology Stack

- Backend Framework: .NET 8, ASP.NET Core
- ORM: Entity Framework Core
- Database: PostgreSQL
- API Integration: Plaid API for financial data
- Frontend (planned): React for a responsive and user-friendly interface

## Architecture Overview

- Domain-Driven Design: Structured to provide clear separation of concerns and maintainable code.
- Service Layer: Handles business logic, integrating with the Plaid API and interacting with the database through repositories.
- Repository Pattern: Provides an abstraction layer for data access, improving code maintainability and testability.

## Planned Features

- Income and Expense Tracking: Automatically categorize transactions from connected bank accounts.
- Budgeting Tools: Simple budgeting tools to help users manage their finances better.
- Financial Reports: Generate basic financial reports to give users insights into their spending habits.
- Savings Goals: Allow users to set and track progress toward savings goals.


